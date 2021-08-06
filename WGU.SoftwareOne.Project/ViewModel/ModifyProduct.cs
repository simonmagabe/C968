using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WGU.SoftwareOne.Project.Model;

namespace WGU.SoftwareOne.Project.ViewModel
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> partsAssociatedList = new BindingList<Part>();
        readonly MainScreen MainScreenPage = (MainScreen)Application.OpenForms["MainScreen"];
        readonly AddPart addPart = new AddPart();

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            ProductFormTextBoxValidation();
            ModifyProductScreenLoad(product);
        }

        public ModifyProduct()
        {

        }

        #region Helper Methods
        private void ModifyProductScreenLoad(Product currentProduct)
        {
            String partId = "Part ID";
            String partName = "Part Name";
            string partInventory = "Inventory";
            string partPrice = "Price";

            ModifyProductIDTextBox.Text = currentProduct.ProductID.ToString();
            ModifyProductNameTextBox.Text = currentProduct.Name;
            ModifyProductInventoryTextBox.Text = currentProduct.InStock.ToString();
            ModifyProductPriceTextBox.Text = currentProduct.Price.ToString();
            ModifyProductMaxTextBox.Text = currentProduct.Max.ToString();
            ModifyProductMinTextBox.Text = currentProduct.Min.ToString();

            BindingSource allPartsBindingSource = new BindingSource();
            allPartsBindingSource.DataSource = Inventory.AllParts;
            dataGridViewModifyProductAllParts.DataSource = allPartsBindingSource;

            dataGridViewModifyProductAllParts.Columns["ID"].HeaderText = partId;
            dataGridViewModifyProductAllParts.Columns["Name"].HeaderText = partName;
            dataGridViewModifyProductAllParts.Columns["InStock"].HeaderText = partInventory;
            dataGridViewModifyProductAllParts.Columns["Price"].HeaderText = partPrice;

            foreach (Part part in currentProduct.AssociatedParts)
            {
                partsAssociatedList.Add(part);
            }

            BindingSource associatedPartBindingSource = new BindingSource();
            associatedPartBindingSource.DataSource = partsAssociatedList;
            dataGridViewModifyProductPartsAssociated.DataSource = associatedPartBindingSource;

            dataGridViewModifyProductPartsAssociated.Columns["ID"].HeaderText = partId;
            dataGridViewModifyProductPartsAssociated.Columns["Name"].HeaderText = partName;
            dataGridViewModifyProductPartsAssociated.Columns["InStock"].HeaderText = partInventory;
            dataGridViewModifyProductPartsAssociated.Columns["Price"].HeaderText = partPrice;

            DisablePartSearchButton(ModifyProductAllPartsSearchBtn, ModifyProductAllPartsSearchTxtBox);
            ModifyProductDeleteAssociatedPartBtn.Enabled = false;
            ModifyProductAddPartBtn.Enabled = false;
        }

        private void ProductFormTextBoxValidation()
        {
            TextBox productIdTextBox = ModifyProductIDTextBox;
            TextBox productNameTextBox = ModifyProductNameTextBox;
            TextBox productInventoryTextBox = ModifyProductInventoryTextBox;
            TextBox productPriceTextBox = ModifyProductPriceTextBox;
            TextBox productMaxTextBox = ModifyProductMaxTextBox;
            TextBox productMinTextBox = ModifyProductMinTextBox;

            bool areAllTextBoxEmpty = productIdTextBox.Text == "" || productNameTextBox.Text == "" || productInventoryTextBox.Text == "" ||
                productPriceTextBox.Text == "" || productMaxTextBox.Text == "" || productMinTextBox.Text == "";

            ModifyProductSaveBtn.Enabled = true ? !areAllTextBoxEmpty : ModifyProductSaveBtn.Enabled = false;
        }

        public void DisablePartSearchButton(Button button, TextBox textBox)
        {
            if (button != null && textBox != null)
            {
                if (String.IsNullOrWhiteSpace(textBox.Text))
                {
                    button.Enabled = false;
                }
                else
                {
                    button.Enabled = true;
                }
            }
        }

        public void ValidateRowIsSelectedOnGridView(DataGridView dataGridView, Button button)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (dataGridView.CurrentRow.Selected)
                {
                    button.Enabled = false;
                }
                else
                {
                    button.Enabled = true;
                }
            }
        }
        #endregion


        #region Mouse Down Event Listeners
        private void DataGridViewModifyProductAllParts_MouseDown(object sender, MouseEventArgs e)
        {
            ValidateRowIsSelectedOnGridView(dataGridViewModifyProductAllParts, ModifyProductAddPartBtn);
        }

        private void DataGridViewModifyProductPartsAssociated_MouseDown(object sender, MouseEventArgs e)
        {
            ValidateRowIsSelectedOnGridView(dataGridViewModifyProductPartsAssociated, ModifyProductDeleteAssociatedPartBtn);
        }
        #endregion


        #region Button Clicks Event Listeners
        private void AddProductDeleteAssociatedPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (partsAssociatedList.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete selected part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        partsAssociatedList.Remove((Part)dataGridViewModifyProductPartsAssociated.CurrentRow.DataBoundItem);

                        ModifyProductDeleteAssociatedPartBtn.Enabled = false;
                    }
                    else
                    {
                        Console.WriteLine("The part was not deleted");
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception mesage: {exce.Message}");
                Console.WriteLine($"An exception stack trace mesage: {exce.StackTrace}");
            }
        }

        private void AllPartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewModifyProductAllParts.ClearSelection();
        }

        private void AssociatedPartDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewModifyProductPartsAssociated.ClearSelection();
        }

        private void ProductAddPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Part associatePart = (Part)dataGridViewModifyProductAllParts.CurrentRow.DataBoundItem;
                partsAssociatedList.Add(associatePart);
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception stack trace message: {exce.StackTrace}");
            }
        }
        private void ModifyProductAllPartsSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int searchId = int.Parse(ModifyProductAllPartsSearchTxtBox.Text);
                Part findPart = Inventory.LookupPart(searchId);

                foreach (DataGridViewRow item in dataGridViewModifyProductAllParts.Rows)
                {
                    Part part = (Part)item.DataBoundItem;

                    if (part.ID.Equals(findPart.ID))
                    {
                        item.Selected = true;
                        break;
                    }
                    else
                    {
                        item.Selected = false;
                        MessageBox.Show($"No match for part with Id :'{searchId}'. Search again with a different Id!");
                        return;
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception message: {exce.StackTrace}");
            }
        }

        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(ModifyProductIDTextBox.Text);
                string productName = ModifyProductNameTextBox.Text;
                int productInventory = int.Parse(ModifyProductInventoryTextBox.Text);
                decimal productPrice = decimal.Parse(ModifyProductPriceTextBox.Text);
                int productMax = int.Parse(ModifyProductMaxTextBox.Text);
                int productMin = int.Parse(ModifyProductMinTextBox.Text);

                if (productMax < productMin)
                {
                    MessageBox.Show($"Maximum value '{productMax}' cannot be less than Minimum value '{productMin}'.");
                    return;
                }

                if (productInventory < productMin || productInventory > productMax)
                {
                    MessageBox.Show($"Inventory value cannot be greater than the Maximum value " +
                        $"nor less that Minimum value.");
                    return;
                }

                Product alteredProduct = new Product(productId, productName, productInventory, productPrice, productMax, productMin);

                foreach (Part part in partsAssociatedList)
                {
                    alteredProduct.AddAssociatedPart(part);
                }

                Inventory.UpdateProduct(productId, alteredProduct);
                Close();
                new MainScreen("HomePage").Show();

                MainScreenPage.MainFormDefaultLoad();
                MainScreenPage.productDataGridView.Update();
                MainScreenPage.productDataGridView.Refresh();
                MainScreenPage.ValidateRowIsSelectedOnPartGridView();
                MainScreenPage.ValidateRowIsSelectedOnProductGridView();
                MainScreenPage.DisableSearchButtonWhenSearchTextEmpty();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception message: {ex.Message}");
                Console.WriteLine($"An exception stack trace message: {ex.StackTrace}");
            }
        }

        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            new MainScreen("HomePage").Show();
        }
        #endregion


        #region TextBox Changed Event Listeners
        private void ModifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductNameTextBox.Text == "")
            {
                ModifyProductNameTextBox.BackColor = Color.OrangeRed;
            }
            else
            {
                ModifyProductNameTextBox.BackColor = Color.White;
            }

            ProductFormTextBoxValidation();
        }

        private void ModifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductInventoryTextBox.Text == "")
            {
                ModifyProductInventoryTextBox.BackColor = Color.OrangeRed;
            }
            else
            {
                ModifyProductInventoryTextBox.BackColor = Color.White;
            }

            ProductFormTextBoxValidation();
        }

        private void ModifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductPriceTextBox.Text == "")
            {
                ModifyProductPriceTextBox.BackColor = Color.OrangeRed;
            }
            else
            {
                ModifyProductPriceTextBox.BackColor = Color.White;
            }

            ProductFormTextBoxValidation();
        }

        private void ModifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductMaxTextBox.Text == "")
            {
                ModifyProductMaxTextBox.BackColor = Color.OrangeRed;
            }
            else
            {
                ModifyProductMaxTextBox.BackColor = Color.White;
            }

            ProductFormTextBoxValidation();
        }

        private void ModifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductMinTextBox.Text == "")
            {
                ModifyProductMinTextBox.BackColor = Color.OrangeRed;
            }
            else
            {
                ModifyProductMinTextBox.BackColor = Color.White;
            }

            ProductFormTextBoxValidation();
        }
        private void ModifyProductAllPartsSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyProductAllPartsSearchTxtBox.Text.Length > 0)
            {
                ModifyProductAllPartsSearchBtn.Enabled = true;
            }
            else
            {
                ModifyProductAllPartsSearchBtn.Enabled = false;
            }
        }
        #endregion


        #region KeyPress Validations
        private void ModifyProductAllPartsSearchTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please search by an Id number Only. E.g '2'.");
                return;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ModifyProductMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyProductNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyProductInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.AllowDecimalPoints(sender, e);
        }

        private void ModifyProductMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }
        #endregion


        #region // Cell Click Event Listeners
        private void dataGridViewModifyProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ModifyProductAddPartBtn.Enabled = true;
            }
            else
            {
                ModifyProductAddPartBtn.Enabled = false;
            }
        }

        private void dataGridViewModifyProductPartsAssociated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ModifyProductDeleteAssociatedPartBtn.Enabled = true;
            }
            else
            {
                ModifyProductDeleteAssociatedPartBtn.Enabled = false;
            }
        }
        #endregion
    }
}
