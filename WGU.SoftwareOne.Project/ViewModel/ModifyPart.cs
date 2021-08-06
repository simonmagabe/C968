using System;
using System.Drawing;
using System.Windows.Forms;
using WGU.SoftwareOne.Project.Model;

namespace WGU.SoftwareOne.Project.ViewModel
{
    public partial class ModifyPart : Form
    {
        readonly AddPart addPart = new AddPart();
        readonly MainScreen MainHomePage = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyPart(InHouse inHousePart)
        {
            InitializeComponent();
            PartFormTextBoxValidation();
            FetchCurrentInHousePartData(inHousePart);
        }

        public ModifyPart(Outsourced outsourcedPart)
        {
            InitializeComponent();
            FetchCurrentOutsourcedPartData(outsourcedPart);
        }

        #region Helper Methods
        private void FetchCurrentOutsourcedPartData(Outsourced outsourcedPart)
        {
            ModifyPartIDTextBox.Text = outsourcedPart.ID.ToString().Trim();
            ModifyPartNameTextBox.Text = outsourcedPart.Name.Trim();
            ModifyPartInventoryTextBox.Text = outsourcedPart.InStock.ToString().Trim();
            ModifyPartPriceTextBox.Text = outsourcedPart.Price.ToString().Trim();
            ModifyPartMaxTextBox.Text = outsourcedPart.Max.ToString().Trim();
            ModifyPartMinTextBox.Text = outsourcedPart.Min.ToString().Trim();
            ModifyPartDynamicTextBox.Text = outsourcedPart.CompanyName.Trim();

            ModifyPartOutsourcedBtn.Checked = true;
        }

        private void FetchCurrentInHousePartData(InHouse inHousePart)
        {
            ModifyPartIDTextBox.Text = inHousePart.ID.ToString().Trim();
            ModifyPartNameTextBox.Text = inHousePart.Name.Trim();
            ModifyPartInventoryTextBox.Text = inHousePart.InStock.ToString().Trim();
            ModifyPartPriceTextBox.Text = inHousePart.Price.ToString().Trim();
            ModifyPartMaxTextBox.Text = inHousePart.Max.ToString().Trim();
            ModifyPartMinTextBox.Text = inHousePart.Min.ToString().Trim();
            ModifyPartDynamicTextBox.Text = inHousePart.MachineID.ToString();

            ModifyPartInHousedBtn.Checked = true;
        }
        private void PartFormTextBoxValidation()
        {
            TextBox partIdTextBox = ModifyPartIDTextBox;
            TextBox partNameTextBox = ModifyPartNameTextBox;
            TextBox partInventoryTextBox = ModifyPartInventoryTextBox;
            TextBox partPriceTextBox = ModifyPartPriceTextBox;
            TextBox partMaxTextBox = ModifyPartMaxTextBox;
            TextBox partMinTextBox = ModifyPartMinTextBox;
            TextBox partDynamicTextBox = ModifyPartDynamicTextBox;

            bool areAllTextBoxEmpty = partIdTextBox.Text == "" || partNameTextBox.Text == "" || partInventoryTextBox.Text == "" ||
                partPriceTextBox.Text == "" || partMaxTextBox.Text == "" || partMinTextBox.Text == "" || partDynamicTextBox.Text == "";

            ModifyPartSaveBtn.Enabled = true ? !areAllTextBoxEmpty : ModifyPartSaveBtn.Enabled = false;
        }
        #endregion


        #region // Checkbox Changed Event Listeners
        private void ModifyPartInHousedBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartInHousedBtn.Checked)
            {
                Console.WriteLine("The InHouse Button is checked");
                ModifyPartDynamicLbl.Text = "Machine ID";
            }
        }

        private void ModifyPartOutsourcedBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartOutsourcedBtn.Checked)
            {
                Console.WriteLine("The Outsourced Button is checked and the label is Company Name");
                ModifyPartDynamicLbl.Text = "Company Name";
            }
            else
            {
                ModifyPartDynamicTextBox.Text = "";
            }
        }
        #endregion


        #region TextBoxes KeyPress Event Listeners
        private void ModifyPartInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPart.HandleCharacters(sender, e);
        }

        private void ModifyPartDynamicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ModifyPartInHousedBtn.Checked && ModifyPartDynamicLbl.Text == "Machine ID")
            {
                addPart.HandleCharacters(sender, e);
            }
        }

        private void ModifyPartPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion


        #region Button Click Event Listeners
        private void ModifyPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainScreen("HomePage").Show();
        }

        private void ModifyPartSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int partMax = int.Parse(ModifyPartMaxTextBox.Text);
                int partMin = int.Parse(ModifyPartMinTextBox.Text);
                int partId = int.Parse(ModifyPartIDTextBox.Text);
                string partName = ModifyPartNameTextBox.Text;
                int partInStock = int.Parse(ModifyPartInventoryTextBox.Text);
                decimal partPrice = decimal.Parse(ModifyPartPriceTextBox.Text);

                if (partMax < partMin)
                {
                    MessageBox.Show($"Maximum value '{partMax}' cannot be less than Minimum value '{partMin}'.");
                    return;
                }

                if (partInStock < partMin || partInStock > partMax)
                {
                    MessageBox.Show($"Inventory value cannot be greater than the Maximum value " +
                        $"nor less that Minimum value.");
                    return;
                }

                if (ModifyPartInHousedBtn.Checked)
                {
                    int partMachineId = int.Parse(ModifyPartDynamicTextBox.Text);
                    InHouse inHousePart = new InHouse(partId, partName, partInStock, partPrice, partMax, partMin, partMachineId);
                    Inventory.UpdatePart(partId, inHousePart);
                }
                else
                {
                    string partCompanyName = ModifyPartDynamicTextBox.Text;
                    Outsourced outsourcedPart = new Outsourced(partId, partName, partInStock, partPrice, partMax, partMin, partCompanyName);
                    Inventory.UpdatePart(partId, outsourcedPart);
                }

                Close();

                MainHomePage.MainFormDefaultLoad();
                MainHomePage.partDataGridView.Update();
                MainHomePage.partDataGridView.Refresh();
                new MainScreen("HomePage").Show();
            }
            catch (Exception exce)
            {
                Console.WriteLine($"An exception message: {exce.Message}");
                Console.WriteLine($"An exception stack trace message: {exce.StackTrace}");
            }
        }
        #endregion


        #region TextBox Changed Event Listeners
        private void ModifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartNameTextBox.Text.Length > 0 ? ModifyPartNameTextBox.BackColor = Color.White : ModifyPartNameTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }

        private void ModifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartInventoryTextBox.Text.Length > 0 ? ModifyPartInventoryTextBox.BackColor = Color.White : ModifyPartInventoryTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }

        private void ModifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartPriceTextBox.Text.Length > 0 ? ModifyPartPriceTextBox.BackColor = Color.White : ModifyPartPriceTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }

        private void ModifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartMaxTextBox.Text.Length > 0 ? ModifyPartMaxTextBox.BackColor = Color.White : ModifyPartMaxTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }

        private void ModifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartMinTextBox.Text.Length > 0 ? ModifyPartMinTextBox.BackColor = Color.White : ModifyPartMinTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }

        private void ModifyPartDynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = ModifyPartDynamicTextBox.Text.Length > 0 ? ModifyPartDynamicTextBox.BackColor = Color.White : ModifyPartDynamicTextBox.BackColor = Color.OrangeRed;
            PartFormTextBoxValidation();
        }
        #endregion
    }
}
