using System;
using System.Windows.Forms;
using WGU.SoftwareOne.Project.Model;
using WGU.SoftwareOne.Project.ViewModel;

namespace WGU.SoftwareOne.Project
{

    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Inventory.InventoryManagementSystemData();
            MainFormDefaultLoad();
        }

        public  MainScreen(string defaultHomePage)
        {
            InitializeComponent();
            MainFormDefaultLoad();
        }

        #region // Helper Methods
        public void MainFormDefaultLoad()
        {
            DataGridViewSelectionMode fullRowSelect = DataGridViewSelectionMode.FullRowSelect;


            BindingSource partsBindingSource = new BindingSource
            {
                DataSource = Inventory.AllParts
            };
            partDataGridView.DataSource = partsBindingSource;



            partDataGridView.SelectionMode = fullRowSelect;
            partDataGridView.ReadOnly = true;
            partDataGridView.AllowUserToAddRows = false;
            partDataGridView.AllowUserToDeleteRows = false;
            partDataGridView.Columns["ID"].HeaderText = "Part ID";
            partDataGridView.Columns["Name"].HeaderText = "Part Name";
            partDataGridView.Columns["Name"].Width = 124;
            partDataGridView.Columns["InStock"].HeaderText = "Inventory";


            BindingSource productsBindingSource = new BindingSource
            {
                DataSource = Inventory.AllProducts
            };
            productDataGridView.DataSource = productsBindingSource;

            productDataGridView.SelectionMode = fullRowSelect;
            productDataGridView.ReadOnly = true;
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.AllowUserToDeleteRows = false;
            productDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            productDataGridView.Columns["Name"].HeaderText = "Product Name";
            productDataGridView.Columns["Name"].Width = 125;
            productDataGridView.Columns["InStock"].HeaderText = "Inventory";

            ValidateRowIsSelectedOnPartGridView();
            ValidateRowIsSelectedOnProductGridView();
            DisableSearchButtonWhenSearchTextEmpty();
        }

        public void ValidateRowIsSelectedOnPartGridView()
        {
            if (partDataGridView.CurrentRow != null)
            {
                PartModifyBtn.Enabled = true;
                PartDeleteBtn.Enabled = true;
            }
            else
            {
                PartModifyBtn.Enabled = false;
                PartDeleteBtn.Enabled = false;
            }
        }

        public void ValidateRowIsSelectedOnProductGridView()
        {
            if (productDataGridView.CurrentRow != null)
            {
                ProductModifyBtn.Enabled = true;
                ProductDeleteBtn.Enabled = true;
            }
            else
            {
                ProductModifyBtn.Enabled = false;
                ProductDeleteBtn.Enabled = false;
            }
        }

        public void DisableSearchButtonWhenSearchTextEmpty()
        {
            _ = partSearchTextBox.Text.Length < 1 ? PartSearchBtn.Enabled = false : PartSearchBtn.Enabled = true;
            _ = productSearchTextBox.Text.Length < 1 ? ProductSearchBtn.Enabled = false : ProductSearchBtn.Enabled = true;
        }
        #endregion


        #region // Auto Clear Auto-Selected Row on Grid View Event Listeners
        private void PartGridViewBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partDataGridView.ClearSelection();
        }

        private void ProductGridViewBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productDataGridView.ClearSelection();
        }
        #endregion


        #region // Mouse Down on GridView Event Listeners
        private void PartDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ValidateRowIsSelectedOnPartGridView();
        }

        private void ProductDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ValidateRowIsSelectedOnProductGridView();
        }
        #endregion


        #region // TextBox  KeyPress Event Listeners
        private void ProductSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.HandleCharacters(sender, e);
        }

        private void PartSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.HandleCharacters(sender, e);
        }

        private void PartSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (partSearchTextBox != null)
            {
                _ = partSearchTextBox.Text.Length > 0 ? PartSearchBtn.Enabled = true : PartSearchBtn.Enabled = false;
            }
        }

        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (productSearchTextBox != null)
            {
                _ = productSearchTextBox.Text.Length > 0 ? ProductSearchBtn.Enabled = true : ProductSearchBtn.Enabled = false;
            }
        }
        #endregion


        #region // Button Click Event Listeners
        private void MainScreenExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PartAddBtn_Click(object sender, EventArgs e)
        {
            new AddPart().Show();
            this.Hide();
        }

        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
            this.Hide();
        }

        private void PartModifyBtn_Click(object sender, EventArgs e)
        {
            if (partDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHousePart = (InHouse)partDataGridView.CurrentRow.DataBoundItem;
                ModifyPart modifyPart = new ModifyPart(inHousePart);
                modifyPart.Show();
                this.Hide();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)partDataGridView.CurrentRow.DataBoundItem;
                ModifyPart modifyPartPage = new ModifyPart(outsourcedPart);
                modifyPartPage.Show();
                this.Hide();
            }
        }

        private void PartDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Count != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete selected part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Inventory.AllParts.Remove((Part)partDataGridView.CurrentRow.DataBoundItem);
                }
            }
        }
        private void ProductModifyBtn_Click(object sender, EventArgs e)
        {
            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            new ModifyProduct(product).Show();
            this.Hide();
        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("A product with an Associated Part(s) cannot be deleted. /nDisassociate part(s) to be able to delete a product!");
                return;
            }

            if (Inventory.AllProducts.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete selected product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Inventory.AllProducts.Remove((Product)productDataGridView.CurrentRow.DataBoundItem);
                }
            }
        }

        private void PartSearchBtn_Click(object sender, EventArgs e)
        {
            int partSearchId = int.Parse(partSearchTextBox.Text);

            Part findPart = Inventory.LookupPart(partSearchId);

            foreach (DataGridViewRow item in partDataGridView.Rows)
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
                }
            }
        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            int productSearchId = int.Parse(productSearchTextBox.Text);
            Product findProduct = Inventory.LookupProduct(productSearchId);

            foreach (DataGridViewRow item in productDataGridView.Rows)
            {
                Product product = (Product)item.DataBoundItem;
                if (product.ProductID.Equals(findProduct.ProductID))
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
        #endregion
    }
}
