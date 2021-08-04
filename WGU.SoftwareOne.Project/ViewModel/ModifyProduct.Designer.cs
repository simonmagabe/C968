
namespace WGU.SoftwareOne.Project.ViewModel
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModifyProductAddPartBtn = new System.Windows.Forms.Button();
            this.ModifyProductSaveBtn = new System.Windows.Forms.Button();
            this.ModifyProductCancelBtn = new System.Windows.Forms.Button();
            this.ModifyProductDeleteAssociatedPartBtn = new System.Windows.Forms.Button();
            this.ProductPartsAssociatedLbl = new System.Windows.Forms.Label();
            this.ModifyProductAllPartsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.ProductAllPartsLbl = new System.Windows.Forms.Label();
            this.ModifyProductAllPartsSearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewModifyProductPartsAssociated = new System.Windows.Forms.DataGridView();
            this.dataGridViewModifyProductAllParts = new System.Windows.Forms.DataGridView();
            this.ModifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.ProductMinLbl = new System.Windows.Forms.Label();
            this.ModifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductMaxLbl = new System.Windows.Forms.Label();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductInventoryLbl = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductPartsAssociated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductAddPartBtn
            // 
            this.ModifyProductAddPartBtn.Location = new System.Drawing.Point(941, 289);
            this.ModifyProductAddPartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductAddPartBtn.Name = "ModifyProductAddPartBtn";
            this.ModifyProductAddPartBtn.Size = new System.Drawing.Size(65, 28);
            this.ModifyProductAddPartBtn.TabIndex = 61;
            this.ModifyProductAddPartBtn.Text = "Add";
            this.ModifyProductAddPartBtn.UseVisualStyleBackColor = true;
            this.ModifyProductAddPartBtn.Click += new System.EventHandler(this.ProductAddPartBtn_Click);
            // 
            // ModifyProductSaveBtn
            // 
            this.ModifyProductSaveBtn.Location = new System.Drawing.Point(875, 615);
            this.ModifyProductSaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductSaveBtn.Name = "ModifyProductSaveBtn";
            this.ModifyProductSaveBtn.Size = new System.Drawing.Size(59, 28);
            this.ModifyProductSaveBtn.TabIndex = 60;
            this.ModifyProductSaveBtn.Text = "Save";
            this.ModifyProductSaveBtn.UseVisualStyleBackColor = true;
            this.ModifyProductSaveBtn.Click += new System.EventHandler(this.ProductSaveBtn_Click);
            // 
            // ModifyProductCancelBtn
            // 
            this.ModifyProductCancelBtn.Location = new System.Drawing.Point(941, 615);
            this.ModifyProductCancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductCancelBtn.Name = "ModifyProductCancelBtn";
            this.ModifyProductCancelBtn.Size = new System.Drawing.Size(65, 28);
            this.ModifyProductCancelBtn.TabIndex = 59;
            this.ModifyProductCancelBtn.Text = "Cancel";
            this.ModifyProductCancelBtn.UseVisualStyleBackColor = true;
            this.ModifyProductCancelBtn.Click += new System.EventHandler(this.AddProductCancelBtn_Click);
            // 
            // ModifyProductDeleteAssociatedPartBtn
            // 
            this.ModifyProductDeleteAssociatedPartBtn.Location = new System.Drawing.Point(941, 562);
            this.ModifyProductDeleteAssociatedPartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductDeleteAssociatedPartBtn.Name = "ModifyProductDeleteAssociatedPartBtn";
            this.ModifyProductDeleteAssociatedPartBtn.Size = new System.Drawing.Size(65, 28);
            this.ModifyProductDeleteAssociatedPartBtn.TabIndex = 58;
            this.ModifyProductDeleteAssociatedPartBtn.Text = "Delete";
            this.ModifyProductDeleteAssociatedPartBtn.UseVisualStyleBackColor = true;
            this.ModifyProductDeleteAssociatedPartBtn.Click += new System.EventHandler(this.AddProductDeleteAssociatedPartBtn_Click);
            // 
            // ProductPartsAssociatedLbl
            // 
            this.ProductPartsAssociatedLbl.AutoSize = true;
            this.ProductPartsAssociatedLbl.Location = new System.Drawing.Point(464, 322);
            this.ProductPartsAssociatedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductPartsAssociatedLbl.Name = "ProductPartsAssociatedLbl";
            this.ProductPartsAssociatedLbl.Size = new System.Drawing.Size(221, 17);
            this.ProductPartsAssociatedLbl.TabIndex = 57;
            this.ProductPartsAssociatedLbl.Text = "Parts Associated with this Product";
            // 
            // ModifyProductAllPartsSearchTxtBox
            // 
            this.ModifyProductAllPartsSearchTxtBox.Location = new System.Drawing.Point(731, 38);
            this.ModifyProductAllPartsSearchTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductAllPartsSearchTxtBox.Name = "ModifyProductAllPartsSearchTxtBox";
            this.ModifyProductAllPartsSearchTxtBox.Size = new System.Drawing.Size(228, 22);
            this.ModifyProductAllPartsSearchTxtBox.TabIndex = 56;
            this.ModifyProductAllPartsSearchTxtBox.TextChanged += new System.EventHandler(this.ModifyProductAllPartsSearchTxtBox_TextChanged);
            this.ModifyProductAllPartsSearchTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductAllPartsSearchTxtBox_KeyPress);
            // 
            // ProductAllPartsLbl
            // 
            this.ProductAllPartsLbl.AutoSize = true;
            this.ProductAllPartsLbl.Location = new System.Drawing.Point(464, 63);
            this.ProductAllPartsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductAllPartsLbl.Name = "ProductAllPartsLbl";
            this.ProductAllPartsLbl.Size = new System.Drawing.Size(60, 17);
            this.ProductAllPartsLbl.TabIndex = 55;
            this.ProductAllPartsLbl.Text = "All Parts";
            // 
            // ModifyProductAllPartsSearchBtn
            // 
            this.ModifyProductAllPartsSearchBtn.Location = new System.Drawing.Point(653, 34);
            this.ModifyProductAllPartsSearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductAllPartsSearchBtn.Name = "ModifyProductAllPartsSearchBtn";
            this.ModifyProductAllPartsSearchBtn.Size = new System.Drawing.Size(69, 28);
            this.ModifyProductAllPartsSearchBtn.TabIndex = 54;
            this.ModifyProductAllPartsSearchBtn.Text = "Search";
            this.ModifyProductAllPartsSearchBtn.UseVisualStyleBackColor = true;
            this.ModifyProductAllPartsSearchBtn.Click += new System.EventHandler(this.ModifyProductAllPartsSearchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Modify Product";
            // 
            // dataGridViewModifyProductPartsAssociated
            // 
            this.dataGridViewModifyProductPartsAssociated.AllowUserToAddRows = false;
            this.dataGridViewModifyProductPartsAssociated.AllowUserToDeleteRows = false;
            this.dataGridViewModifyProductPartsAssociated.AllowUserToResizeColumns = false;
            this.dataGridViewModifyProductPartsAssociated.AllowUserToResizeRows = false;
            this.dataGridViewModifyProductPartsAssociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifyProductPartsAssociated.Location = new System.Drawing.Point(468, 357);
            this.dataGridViewModifyProductPartsAssociated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewModifyProductPartsAssociated.Name = "dataGridViewModifyProductPartsAssociated";
            this.dataGridViewModifyProductPartsAssociated.ReadOnly = true;
            this.dataGridViewModifyProductPartsAssociated.RowHeadersVisible = false;
            this.dataGridViewModifyProductPartsAssociated.RowHeadersWidth = 51;
            this.dataGridViewModifyProductPartsAssociated.RowTemplate.ReadOnly = true;
            this.dataGridViewModifyProductPartsAssociated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModifyProductPartsAssociated.Size = new System.Drawing.Size(539, 185);
            this.dataGridViewModifyProductPartsAssociated.TabIndex = 52;
            this.dataGridViewModifyProductPartsAssociated.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModifyProductPartsAssociated_CellClick);
            this.dataGridViewModifyProductPartsAssociated.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AssociatedPartDataBindingComplete);
            this.dataGridViewModifyProductPartsAssociated.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewModifyProductPartsAssociated_MouseDown);
            // 
            // dataGridViewModifyProductAllParts
            // 
            this.dataGridViewModifyProductAllParts.AllowUserToAddRows = false;
            this.dataGridViewModifyProductAllParts.AllowUserToDeleteRows = false;
            this.dataGridViewModifyProductAllParts.AllowUserToResizeColumns = false;
            this.dataGridViewModifyProductAllParts.AllowUserToResizeRows = false;
            this.dataGridViewModifyProductAllParts.ColumnHeadersHeight = 29;
            this.dataGridViewModifyProductAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewModifyProductAllParts.Location = new System.Drawing.Point(468, 95);
            this.dataGridViewModifyProductAllParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewModifyProductAllParts.MultiSelect = false;
            this.dataGridViewModifyProductAllParts.Name = "dataGridViewModifyProductAllParts";
            this.dataGridViewModifyProductAllParts.ReadOnly = true;
            this.dataGridViewModifyProductAllParts.RowHeadersVisible = false;
            this.dataGridViewModifyProductAllParts.RowHeadersWidth = 51;
            this.dataGridViewModifyProductAllParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModifyProductAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModifyProductAllParts.Size = new System.Drawing.Size(539, 185);
            this.dataGridViewModifyProductAllParts.TabIndex = 51;
            this.dataGridViewModifyProductAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModifyProductAllParts_CellClick);
            this.dataGridViewModifyProductAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartsDataBindingComplete);
            this.dataGridViewModifyProductAllParts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewModifyProductAllParts_MouseDown);
            // 
            // ModifyProductMinTextBox
            // 
            this.ModifyProductMinTextBox.Location = new System.Drawing.Point(277, 377);
            this.ModifyProductMinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductMinTextBox.Name = "ModifyProductMinTextBox";
            this.ModifyProductMinTextBox.Size = new System.Drawing.Size(99, 22);
            this.ModifyProductMinTextBox.TabIndex = 50;
            this.ModifyProductMinTextBox.TextChanged += new System.EventHandler(this.ModifyProductMinTextBox_TextChanged);
            this.ModifyProductMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMinTextBox_KeyPress);
            // 
            // ProductMinLbl
            // 
            this.ProductMinLbl.AutoSize = true;
            this.ProductMinLbl.Location = new System.Drawing.Point(237, 380);
            this.ProductMinLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductMinLbl.Name = "ProductMinLbl";
            this.ProductMinLbl.Size = new System.Drawing.Size(30, 17);
            this.ProductMinLbl.TabIndex = 49;
            this.ProductMinLbl.Text = "Min";
            // 
            // ModifyProductMaxTextBox
            // 
            this.ModifyProductMaxTextBox.Location = new System.Drawing.Point(100, 380);
            this.ModifyProductMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductMaxTextBox.Name = "ModifyProductMaxTextBox";
            this.ModifyProductMaxTextBox.Size = new System.Drawing.Size(95, 22);
            this.ModifyProductMaxTextBox.TabIndex = 48;
            this.ModifyProductMaxTextBox.TextChanged += new System.EventHandler(this.ModifyProductMaxTextBox_TextChanged);
            this.ModifyProductMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMaxTextBox_KeyPress);
            // 
            // ModifyProductPriceTextBox
            // 
            this.ModifyProductPriceTextBox.Location = new System.Drawing.Point(132, 341);
            this.ModifyProductPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductPriceTextBox.Name = "ModifyProductPriceTextBox";
            this.ModifyProductPriceTextBox.Size = new System.Drawing.Size(169, 22);
            this.ModifyProductPriceTextBox.TabIndex = 47;
            this.ModifyProductPriceTextBox.TextChanged += new System.EventHandler(this.ModifyProductPriceTextBox_TextChanged);
            this.ModifyProductPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductPriceTextBox_KeyPress);
            // 
            // ModifyProductInventoryTextBox
            // 
            this.ModifyProductInventoryTextBox.Location = new System.Drawing.Point(132, 302);
            this.ModifyProductInventoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductInventoryTextBox.Name = "ModifyProductInventoryTextBox";
            this.ModifyProductInventoryTextBox.Size = new System.Drawing.Size(169, 22);
            this.ModifyProductInventoryTextBox.TabIndex = 46;
            this.ModifyProductInventoryTextBox.TextChanged += new System.EventHandler(this.ModifyProductInventoryTextBox_TextChanged);
            this.ModifyProductInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductInventoryTextBox_KeyPress);
            // 
            // ModifyProductNameTextBox
            // 
            this.ModifyProductNameTextBox.Location = new System.Drawing.Point(132, 260);
            this.ModifyProductNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductNameTextBox.Name = "ModifyProductNameTextBox";
            this.ModifyProductNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.ModifyProductNameTextBox.TabIndex = 45;
            this.ModifyProductNameTextBox.TextChanged += new System.EventHandler(this.ModifyProductNameTextBox_TextChanged);
            // 
            // ModifyProductIDTextBox
            // 
            this.ModifyProductIDTextBox.Enabled = false;
            this.ModifyProductIDTextBox.Location = new System.Drawing.Point(132, 219);
            this.ModifyProductIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyProductIDTextBox.Name = "ModifyProductIDTextBox";
            this.ModifyProductIDTextBox.Size = new System.Drawing.Size(169, 22);
            this.ModifyProductIDTextBox.TabIndex = 44;
            // 
            // ProductMaxLbl
            // 
            this.ProductMaxLbl.AutoSize = true;
            this.ProductMaxLbl.Location = new System.Drawing.Point(56, 380);
            this.ProductMaxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductMaxLbl.Name = "ProductMaxLbl";
            this.ProductMaxLbl.Size = new System.Drawing.Size(33, 17);
            this.ProductMaxLbl.TabIndex = 43;
            this.ProductMaxLbl.Text = "Max";
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Location = new System.Drawing.Point(56, 345);
            this.ProductPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(40, 17);
            this.ProductPriceLbl.TabIndex = 42;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ProductInventoryLbl
            // 
            this.ProductInventoryLbl.AutoSize = true;
            this.ProductInventoryLbl.Location = new System.Drawing.Point(56, 302);
            this.ProductInventoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductInventoryLbl.Name = "ProductInventoryLbl";
            this.ProductInventoryLbl.Size = new System.Drawing.Size(66, 17);
            this.ProductInventoryLbl.TabIndex = 41;
            this.ProductInventoryLbl.Text = "Inventory";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(56, 263);
            this.ProductNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(45, 17);
            this.ProductNameLbl.TabIndex = 40;
            this.ProductNameLbl.Text = "Name";
            // 
            // ProductIdLbl
            // 
            this.ProductIdLbl.AutoSize = true;
            this.ProductIdLbl.Location = new System.Drawing.Point(56, 223);
            this.ProductIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductIdLbl.Name = "ProductIdLbl";
            this.ProductIdLbl.Size = new System.Drawing.Size(21, 17);
            this.ProductIdLbl.TabIndex = 39;
            this.ProductIdLbl.Text = "ID";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 682);
            this.Controls.Add(this.ModifyProductAddPartBtn);
            this.Controls.Add(this.ModifyProductSaveBtn);
            this.Controls.Add(this.ModifyProductCancelBtn);
            this.Controls.Add(this.ModifyProductDeleteAssociatedPartBtn);
            this.Controls.Add(this.ProductPartsAssociatedLbl);
            this.Controls.Add(this.ModifyProductAllPartsSearchTxtBox);
            this.Controls.Add(this.ProductAllPartsLbl);
            this.Controls.Add(this.ModifyProductAllPartsSearchBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewModifyProductPartsAssociated);
            this.Controls.Add(this.dataGridViewModifyProductAllParts);
            this.Controls.Add(this.ModifyProductMinTextBox);
            this.Controls.Add(this.ProductMinLbl);
            this.Controls.Add(this.ModifyProductMaxTextBox);
            this.Controls.Add(this.ModifyProductPriceTextBox);
            this.Controls.Add(this.ModifyProductInventoryTextBox);
            this.Controls.Add(this.ModifyProductNameTextBox);
            this.Controls.Add(this.ModifyProductIDTextBox);
            this.Controls.Add(this.ProductMaxLbl);
            this.Controls.Add(this.ProductPriceLbl);
            this.Controls.Add(this.ProductInventoryLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.ProductIdLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductPartsAssociated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyProductAddPartBtn;
        private System.Windows.Forms.Button ModifyProductSaveBtn;
        private System.Windows.Forms.Button ModifyProductCancelBtn;
        private System.Windows.Forms.Button ModifyProductDeleteAssociatedPartBtn;
        private System.Windows.Forms.Label ProductPartsAssociatedLbl;
        private System.Windows.Forms.TextBox ModifyProductAllPartsSearchTxtBox;
        private System.Windows.Forms.Label ProductAllPartsLbl;
        private System.Windows.Forms.Button ModifyProductAllPartsSearchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewModifyProductPartsAssociated;
        private System.Windows.Forms.DataGridView dataGridViewModifyProductAllParts;
        private System.Windows.Forms.TextBox ModifyProductMinTextBox;
        private System.Windows.Forms.Label ProductMinLbl;
        private System.Windows.Forms.TextBox ModifyProductMaxTextBox;
        private System.Windows.Forms.TextBox ModifyProductPriceTextBox;
        private System.Windows.Forms.TextBox ModifyProductInventoryTextBox;
        private System.Windows.Forms.TextBox ModifyProductNameTextBox;
        private System.Windows.Forms.TextBox ModifyProductIDTextBox;
        private System.Windows.Forms.Label ProductMaxLbl;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Label ProductInventoryLbl;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductIdLbl;
    }
}