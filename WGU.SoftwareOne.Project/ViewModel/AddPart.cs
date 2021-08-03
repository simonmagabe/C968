using System;
using System.Drawing;
using System.Windows.Forms;
using WGU.SoftwareOne.Project.Model;

namespace WGU.SoftwareOne.Project.ViewModel
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            PartFormTextBoxValidation();
            SetBackGroundColorForPartRequiredFields();
        }

        #region // Helper methods
        private void SetBackGroundColorForPartRequiredFields()
        {
            _ = AddPartNameTextBox.Text.Length > 0 ? AddPartNameTextBox.BackColor = Color.White : AddPartNameTextBox.BackColor = Color.OrangeRed;
            _ = AddPartInventoryTextBox.Text.Length > 0 ? AddPartInventoryTextBox.BackColor = Color.White : AddPartInventoryTextBox.BackColor = Color.OrangeRed;
            _ = AddPartPriceTextBox.Text.Length > 0 ? AddPartPriceTextBox.BackColor = Color.White : AddPartPriceTextBox.BackColor = Color.OrangeRed;
            _ = AddPartMaxTextBox.Text.Length > 0 ? AddPartMaxTextBox.BackColor = Color.White : AddPartMaxTextBox.BackColor = Color.OrangeRed;
            _ = AddPartMinTextBox.Text.Length > 0 ? AddPartMinTextBox.BackColor = Color.White : AddPartMinTextBox.BackColor = Color.OrangeRed;
            _ = AddPartDynamicTextBox.Text.Length > 0 ? AddPartDynamicTextBox.BackColor = Color.White : AddPartDynamicTextBox.BackColor = Color.OrangeRed;
        }
        public void HandleCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("This textbox accepts numbers only.");
            }
        }

        public void AllowDecimalPoints(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PartFormTextBoxValidation()
        {
            TextBox partNameTextBox = AddPartNameTextBox;
            TextBox partInventoryTextBox = AddPartInventoryTextBox;
            TextBox partPriceTextBox = AddPartPriceTextBox;
            TextBox partMaxTextBox = AddPartMaxTextBox;
            TextBox partMinTextBox = AddPartMinTextBox;
            TextBox partDynamicTextBox = AddPartDynamicTextBox;

            bool areAllTextBoxEmpty = partNameTextBox.Text == "" || partInventoryTextBox.Text == "" ||
                partPriceTextBox.Text == "" || partMaxTextBox.Text == "" || partMinTextBox.Text == "" || partDynamicTextBox.Text == "";

            AddPartSaveBtn.Enabled = true ? !areAllTextBoxEmpty : AddPartSaveBtn.Enabled = false;
        }
        #endregion

        #region // CheckBox Changed Event Listeners
        private void AddPartOutsourcedBtn_CheckedChanged(object sender, EventArgs e)
        {
            AddPartDynamicLbl.Text = "Company Name";
            AddPartDynamicTextBox.Text = "";
        }

        private void AddPartInHousedBtn_CheckedChanged(object sender, EventArgs e)
        {
            AddPartDynamicLbl.Text = "Machine ID";
            AddPartDynamicTextBox.Text = "";
        }
        #endregion

        #region // TextBox Changed Event Listeners
        private void AddPartIDTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();
        }

        private void AddPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            _ = AddPartNameTextBox.Text.Length > 0 ? AddPartNameTextBox.BackColor = Color.White : AddPartNameTextBox.BackColor = Color.OrangeRed;
        }

        private void AddPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            _ = AddPartInventoryTextBox.Text.Length > 0 ? AddPartInventoryTextBox.BackColor = Color.White : AddPartInventoryTextBox.BackColor = Color.OrangeRed;
        }

        private void AddPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            _ = AddPartPriceTextBox.Text.Length > 0 ? AddPartPriceTextBox.BackColor = Color.White : AddPartPriceTextBox.BackColor = Color.OrangeRed;
        }

        private void AddPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            _ = AddPartMaxTextBox.Text.Length > 0 ? AddPartMaxTextBox.BackColor = Color.White : AddPartMaxTextBox.BackColor = Color.OrangeRed;
        }

        private void AddPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            _ = AddPartMinTextBox.Text.Length > 0 ? AddPartMinTextBox.BackColor = Color.White : AddPartMinTextBox.BackColor = Color.OrangeRed;
        }

        private void AddPartDynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();
            
            _ = AddPartDynamicTextBox.Text.Length > 0 ? AddPartDynamicTextBox.BackColor = Color.White : AddPartDynamicTextBox.BackColor = Color.OrangeRed;
        }
        #endregion

        #region // TextBox KeyPress Event Listeners
        private void AddPartInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleCharacters(sender, e);
        }

        private void AddPartPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalPoints(sender, e);
        }

        private void AddPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleCharacters(sender, e);
        }

        private void AddPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleCharacters(sender, e);
        }

        private void AddPartDynamicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AddPartInHousedRadioBtn.Checked)
            {
                HandleCharacters(sender, e);
            }
        }
        #endregion

        #region // Button Clicked Event Listeners
        private void AddPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainScreen("HomePage").Show();
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            PartFormTextBoxValidation();

            int partMax = int.Parse(AddPartMaxTextBox.Text);
            int partMin = int.Parse(AddPartMinTextBox.Text);
            int partId = Inventory.AllParts.Count + 1; ;
            string partName = AddPartNameTextBox.Text;
            int partInStock = int.Parse(AddPartInventoryTextBox.Text);
            decimal partPrice = decimal.Parse(AddPartPriceTextBox.Text);

            if (partMax < partMin)
            {
                MessageBox.Show($"Maximum value '{partMax}' cannot be less than Minimum value '{partMin}'.");
                return;
            }

            if (AddPartInHousedRadioBtn.Checked)
            {
                int partMachineId = int.Parse(AddPartDynamicTextBox.Text);

                InHouse inHousePart = new InHouse(partId, partName, partInStock, partPrice, partMax, partMin, partMachineId);
                Inventory.AddPart(inHousePart);
            }
            else
            {
                string partCompanyName = AddPartDynamicTextBox.Text;
                Outsourced outsourcedPart = new Outsourced(partId, partName, partInStock, partPrice, partMax, partMin, partCompanyName);
                Inventory.AddPart(outsourcedPart);
            }

            this.Close();
            new MainScreen("HomePage").Show();
        }
        #endregion
    }
}
