using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WGU.SoftwareOne.Project.Model;

namespace WGU.SoftwareOne.Project.ViewModel
{
    public partial class AddProduct : Form
    {
        BindingList<Part> associatedPartList = new BindingList<Part>();
        readonly AddPart addPart = new AddPart();
        readonly ModifyProduct ModifyProduct = new ModifyProduct();

        public AddProduct()
        {
            InitializeComponent();
            AddProductOnLoadScreen();
            ProductFormTextBoxValidation();
            SetBackGroundColorForProductRequiredFields();
            ModifyProduct.DisablePartSearchButton(ProductAllPartsSearchBtn, ProductAllPartsSearchTxtBox);
            
        }

        #region // Helper Methods
        private void SetBackGroundColorForProductRequiredFields()
        {
            _ = AddProductNameTextBox.Text.Length > 0 ? AddProductNameTextBox.BackColor = Color.White : AddProductNameTextBox.BackColor = Color.OrangeRed;
            _ = AddProductInventoryTextBox.Text.Length > 0 ? AddProductInventoryTextBox.BackColor = Color.White : AddProductInventoryTextBox.BackColor = Color.OrangeRed;
            _ = AddProductPriceTextBox.Text.Length > 0 ? AddProductPriceTextBox.BackColor = Color.White : AddProductPriceTextBox.BackColor = Color.OrangeRed;
            _ = AddProductMaxTextBox.Text.Length > 0 ? AddProductMaxTextBox.BackColor = Color.White : AddProductMaxTextBox.BackColor = Color.OrangeRed;
            _ = AddProductMinTextBox.Text.Length > 0 ? AddProductMinTextBox.BackColor = Color.White : AddProductMinTextBox.BackColor = Color.OrangeRed;
        }

        public void AddProductOnLoadScreen()
        {
            var partBindingSource = new BindingSource
            {
                DataSource = Inventory.AllParts
            };
            dataGridViewAddProductAllParts.DataSource = partBindingSource;

            dataGridViewAddProductAllParts.Columns["ID"].HeaderText = "Part ID";
            dataGridViewAddProductAllParts.Columns["Name"].HeaderText = "Part Name";
            dataGridViewAddProductAllParts.Columns["InStock"].HeaderText = "Inventory";

            var associatedPartBindingSource = new BindingSource
            {
                DataSource = associatedPartList
            };
            dataGridViewAddProductPartsAssociated.DataSource = associatedPartBindingSource;

            dataGridViewAddProductPartsAssociated.Columns["ID"].HeaderText = "Part ID";
            dataGridViewAddProductPartsAssociated.Columns["Name"].HeaderText = "Part Name";
            dataGridViewAddProductPartsAssociated.Columns["InStock"].HeaderText = "Inventory";

            ToggleDeleteAssociatedPartBtn(ProductDeleteAssociatedPartBtn, associatedPartList);

            if (dataGridViewAddProductAllParts.Rows.Count > 0)
            {
                if (dataGridViewAddProductAllParts.CurrentRow != null)
                {
                    if (dataGridViewAddProductAllParts.CurrentRow.Selected)
                    {
                        ProductAddPartBtn.Enabled = true;
                    }
                    else
                    {
                        ProductAddPartBtn.Enabled = false;
                    }
                }
                else
                {
                    ProductAddPartBtn.Enabled = false;
                }
            }
            else
            {
                ProductAddPartBtn.Enabled = false;
            }
        }

        public void ToggleDeleteAssociatedPartBtn(Button button, BindingList<Part> partsList)
        {
            if (partsList.Count < 1)
            {
                button.Enabled = false;
            }
            else
            {
                button.Enabled = true;
            }
        }
        #endregion


        #region // Button Clicked Event Listeners
        private void ProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainScreen("HomePage").Show();
        }

        private void ProductAddPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAddProductAllParts.CurrentRow != null)
                {
                    if (dataGridViewAddProductAllParts.CurrentRow.Selected)
                    {
                        Part associatedPart = (Part)dataGridViewAddProductAllParts.CurrentRow.DataBoundItem;
                        associatedPartList.Add(associatedPart);
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception stack trace message: {exce.StackTrace}");
            }
        }

        private void ProductAllPartsSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int searchIdValue = int.Parse(ProductAllPartsSearchTxtBox.Text);
                Part foundPart = Inventory.LookupPart(searchIdValue);

                foreach (DataGridViewRow item in dataGridViewAddProductAllParts.Rows)
                {
                    Part part = (Part)item.DataBoundItem;
                    if (part.ID == foundPart.ID)
                    {
                        item.Selected = true;
                        break;
                    }
                    else
                    {
                        item.Selected = false;
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception stack trace message: {exce.StackTrace}");
            }
        }

        private void ProductDeleteAssociatedPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (associatedPartList.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete selected part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        associatedPartList.Remove((Part)dataGridViewAddProductPartsAssociated.CurrentRow.DataBoundItem);

                        if (dataGridViewAddProductPartsAssociated.CurrentRow == null)
                        {
                            ProductDeleteAssociatedPartBtn.Enabled = false;
                        }
                        else
                        {
                            ProductDeleteAssociatedPartBtn.Enabled = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dont do anything");
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine($"Aan exception message: {exce.Message}");
                Console.WriteLine($"Aan exception stack trace message: {exce.StackTrace}");
            }
        }
        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Inventory.AllProducts.Count + 1;
                string productName = AddProductNameTextBox.Text;
                int productInventory = int.Parse(AddProductInventoryTextBox.Text);
                decimal productPrice = decimal.Parse(AddProductPriceTextBox.Text);
                int productMax = int.Parse(AddProductMaxTextBox.Text);
                int productMin = int.Parse(AddProductMinTextBox.Text);

                if (AddProductMaxTextBox != null && AddProductMinTextBox != null)
                {
                    if (productMax > 0 && productMin > 0)
                    {
                        if (productMin > productMax)
                        {
                            string message = $"Minimum value '{productMin}' cannot be greater than the Minimum value '{productMax}'";
                            MessageBox.Show(message);
                            return;
                        }
                    }
                }


                if (productInventory < productMin || productInventory > productMax)
                {
                    MessageBox.Show($"Inventory value cannot be greater than the Maximum value " +
                        $"nor less that Minimum value.");
                    return;
                }

                Product productList = new Product(productId, productName, productInventory, productPrice, productMax, productMin);
                Inventory.AddProduct(productList);

                foreach (Part part in associatedPartList)
                {
                    productList.AddAssociatedPart(part);
                }

                this.Close();
                new MainScreen("HomePage").Show();
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception stack trace message: {exce.StackTrace}");
            }
        }
        #endregion


        #region // Auto Clear Auto-Selected Row on the GridView
        private void AssociatedPartDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAddProductPartsAssociated.ClearSelection();
        }

        private void AllPartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAddProductAllParts.ClearSelection();
        }
        #endregion


        #region // TextBoxes Changed Event Listeners
        private void AddProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductFormTextBoxValidation();
            SetTextBoxRequiredBackColor(AddProductNameTextBox);
        }

        private void AddProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductFormTextBoxValidation();
            SetTextBoxRequiredBackColor(AddProductInventoryTextBox);
        }

        private void AddProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductFormTextBoxValidation();
            SetTextBoxRequiredBackColor(AddProductPriceTextBox);
        }

        private void AddProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductFormTextBoxValidation();
            SetTextBoxRequiredBackColor(AddProductMaxTextBox);
        }

        private void AddProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductFormTextBoxValidation();
            SetTextBoxRequiredBackColor(AddProductMinTextBox);
        }

        static void SetTextBoxRequiredBackColor(TextBox textBox)
        {
            if (textBox != null)
            {
                _ = textBox.Text.Length > 0 ? textBox.BackColor = Color.White : textBox.BackColor = Color.OrangeRed;
            }
        }

        private void ProductFormTextBoxValidation()
        {
            TextBox productIdTextBox = AddProductIDTextBox;
            TextBox productNameTextBox = AddProductNameTextBox;
            TextBox productInventoryTextBox = AddProductInventoryTextBox;
            TextBox productPriceTextBox = AddProductPriceTextBox;
            TextBox productMaxTextBox = AddProductMaxTextBox;
            TextBox productMinTextBox = AddProductMinTextBox;

            bool areAllTextBoxEmpty = productNameTextBox.Text == "" || productInventoryTextBox.Text == "" ||
                productPriceTextBox.Text == "" || productMaxTextBox.Text == "" || productMinTextBox.Text == "";

            ProductSaveBtn.Enabled = true ? !areAllTextBoxEmpty : ProductSaveBtn.Enabled = false;
        }

        private void ProductAllPartsSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ModifyProduct.DisablePartSearchButton(ProductAllPartsSearchBtn, ProductAllPartsSearchTxtBox);
        }
        #endregion


        #region // TextBox KeyPress Event Listeners 
        private void AddProductInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void AddProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.AllowDecimalPoints(sender, e);
        }

        private void AddProductMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void AddProductMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ProductAllPartsSearchTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion


        #region // Mouse Down Event Listeners
        private void DataGridViewAddProductPartsAssociated_MouseDown(object sender, MouseEventArgs e)
        {
            if (dataGridViewAddProductPartsAssociated.CurrentRow != null)
            {
                ProductDeleteAssociatedPartBtn.Enabled = true;
                dataGridViewAddProductPartsAssociated.CurrentRow.DataBoundItem.ToString();
            }
            else
            {
                ProductDeleteAssociatedPartBtn.Enabled = false;
            }
        }
        #endregion


        #region // Cell Click Event Listeners
        private void DataGridViewAddProductPartsAssociated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductDeleteAssociatedPartBtn.Enabled = true;
            }
            else
            {
                ProductDeleteAssociatedPartBtn.Enabled = false;
            }
        }

        private void DataGridViewAddProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductAddPartBtn.Enabled = true;
            }
            else
            {
                ProductAddPartBtn.Enabled = false;
            }
        }
        #endregion
    }
}
