
namespace WGU.SoftwareOne.Project.ViewModel
{
    partial class AddProduct
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
            this.AddProductMinTextBox = new System.Windows.Forms.TextBox();
            this.ProductMinLbl = new System.Windows.Forms.Label();
            this.AddProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.AddProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.AddProductNameTextBox = new System.Windows.Forms.TextBox();
            this.AddProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductMaxLbl = new System.Windows.Forms.Label();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductInventoryLbl = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductIdLbl = new System.Windows.Forms.Label();
            this.dataGridViewAddProductAllParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddProductPartsAssociated = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductAllPartsSearchBtn = new System.Windows.Forms.Button();
            this.ProductAllPartsLbl = new System.Windows.Forms.Label();
            this.ProductAllPartsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.ProductPartsAssociatedLbl = new System.Windows.Forms.Label();
            this.ProductDeleteAssociatedPartBtn = new System.Windows.Forms.Button();
            this.ProductCancelBtn = new System.Windows.Forms.Button();
            this.ProductSaveBtn = new System.Windows.Forms.Button();
            this.ProductAddPartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProductAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProductPartsAssociated)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductMinTextBox
            // 
            this.AddProductMinTextBox.Location = new System.Drawing.Point(206, 307);
            this.AddProductMinTextBox.Name = "AddProductMinTextBox";
            this.AddProductMinTextBox.Size = new System.Drawing.Size(75, 20);
            this.AddProductMinTextBox.TabIndex = 27;
            this.AddProductMinTextBox.TextChanged += new System.EventHandler(this.AddProductMinTextBox_TextChanged);
            this.AddProductMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductMinTextBox_KeyPress);
            // 
            // ProductMinLbl
            // 
            this.ProductMinLbl.AutoSize = true;
            this.ProductMinLbl.Location = new System.Drawing.Point(176, 310);
            this.ProductMinLbl.Name = "ProductMinLbl";
            this.ProductMinLbl.Size = new System.Drawing.Size(24, 13);
            this.ProductMinLbl.TabIndex = 26;
            this.ProductMinLbl.Text = "Min";
            // 
            // AddProductMaxTextBox
            // 
            this.AddProductMaxTextBox.Location = new System.Drawing.Point(73, 310);
            this.AddProductMaxTextBox.Name = "AddProductMaxTextBox";
            this.AddProductMaxTextBox.Size = new System.Drawing.Size(72, 20);
            this.AddProductMaxTextBox.TabIndex = 25;
            this.AddProductMaxTextBox.TextChanged += new System.EventHandler(this.AddProductMaxTextBox_TextChanged);
            this.AddProductMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductMaxTextBox_KeyPress);
            // 
            // AddProductPriceTextBox
            // 
            this.AddProductPriceTextBox.Location = new System.Drawing.Point(97, 278);
            this.AddProductPriceTextBox.Name = "AddProductPriceTextBox";
            this.AddProductPriceTextBox.Size = new System.Drawing.Size(128, 20);
            this.AddProductPriceTextBox.TabIndex = 24;
            this.AddProductPriceTextBox.TextChanged += new System.EventHandler(this.AddProductPriceTextBox_TextChanged);
            this.AddProductPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductPriceTextBox_KeyPress);
            // 
            // AddProductInventoryTextBox
            // 
            this.AddProductInventoryTextBox.Location = new System.Drawing.Point(97, 246);
            this.AddProductInventoryTextBox.Name = "AddProductInventoryTextBox";
            this.AddProductInventoryTextBox.Size = new System.Drawing.Size(128, 20);
            this.AddProductInventoryTextBox.TabIndex = 23;
            this.AddProductInventoryTextBox.TextChanged += new System.EventHandler(this.AddProductInventoryTextBox_TextChanged);
            this.AddProductInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductInventoryTextBox_KeyPress);
            // 
            // AddProductNameTextBox
            // 
            this.AddProductNameTextBox.Location = new System.Drawing.Point(97, 212);
            this.AddProductNameTextBox.Name = "AddProductNameTextBox";
            this.AddProductNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.AddProductNameTextBox.TabIndex = 22;
            this.AddProductNameTextBox.TextChanged += new System.EventHandler(this.AddProductNameTextBox_TextChanged);
            // 
            // AddProductIDTextBox
            // 
            this.AddProductIDTextBox.Enabled = false;
            this.AddProductIDTextBox.Location = new System.Drawing.Point(97, 179);
            this.AddProductIDTextBox.Name = "AddProductIDTextBox";
            this.AddProductIDTextBox.Size = new System.Drawing.Size(128, 20);
            this.AddProductIDTextBox.TabIndex = 21;
            // 
            // ProductMaxLbl
            // 
            this.ProductMaxLbl.AutoSize = true;
            this.ProductMaxLbl.Location = new System.Drawing.Point(40, 310);
            this.ProductMaxLbl.Name = "ProductMaxLbl";
            this.ProductMaxLbl.Size = new System.Drawing.Size(27, 13);
            this.ProductMaxLbl.TabIndex = 20;
            this.ProductMaxLbl.Text = "Max";
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Location = new System.Drawing.Point(40, 281);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(31, 13);
            this.ProductPriceLbl.TabIndex = 19;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ProductInventoryLbl
            // 
            this.ProductInventoryLbl.AutoSize = true;
            this.ProductInventoryLbl.Location = new System.Drawing.Point(40, 246);
            this.ProductInventoryLbl.Name = "ProductInventoryLbl";
            this.ProductInventoryLbl.Size = new System.Drawing.Size(51, 13);
            this.ProductInventoryLbl.TabIndex = 18;
            this.ProductInventoryLbl.Text = "Inventory";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(40, 215);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLbl.TabIndex = 17;
            this.ProductNameLbl.Text = "Name";
            // 
            // ProductIdLbl
            // 
            this.ProductIdLbl.AutoSize = true;
            this.ProductIdLbl.Location = new System.Drawing.Point(40, 182);
            this.ProductIdLbl.Name = "ProductIdLbl";
            this.ProductIdLbl.Size = new System.Drawing.Size(18, 13);
            this.ProductIdLbl.TabIndex = 16;
            this.ProductIdLbl.Text = "ID";
            // 
            // dataGridViewAddProductAllParts
            // 
            this.dataGridViewAddProductAllParts.AllowUserToAddRows = false;
            this.dataGridViewAddProductAllParts.AllowUserToDeleteRows = false;
            this.dataGridViewAddProductAllParts.AllowUserToResizeColumns = false;
            this.dataGridViewAddProductAllParts.AllowUserToResizeRows = false;
            this.dataGridViewAddProductAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProductAllParts.Location = new System.Drawing.Point(349, 78);
            this.dataGridViewAddProductAllParts.MultiSelect = false;
            this.dataGridViewAddProductAllParts.Name = "dataGridViewAddProductAllParts";
            this.dataGridViewAddProductAllParts.ReadOnly = true;
            this.dataGridViewAddProductAllParts.RowHeadersVisible = false;
            this.dataGridViewAddProductAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddProductAllParts.Size = new System.Drawing.Size(404, 150);
            this.dataGridViewAddProductAllParts.TabIndex = 28;
            this.dataGridViewAddProductAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddProductAllParts_CellClick);
            this.dataGridViewAddProductAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartsDataBindingComplete);
            // 
            // dataGridViewAddProductPartsAssociated
            // 
            this.dataGridViewAddProductPartsAssociated.AllowUserToAddRows = false;
            this.dataGridViewAddProductPartsAssociated.AllowUserToDeleteRows = false;
            this.dataGridViewAddProductPartsAssociated.AllowUserToResizeColumns = false;
            this.dataGridViewAddProductPartsAssociated.AllowUserToResizeRows = false;
            this.dataGridViewAddProductPartsAssociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProductPartsAssociated.Location = new System.Drawing.Point(349, 291);
            this.dataGridViewAddProductPartsAssociated.MultiSelect = false;
            this.dataGridViewAddProductPartsAssociated.Name = "dataGridViewAddProductPartsAssociated";
            this.dataGridViewAddProductPartsAssociated.ReadOnly = true;
            this.dataGridViewAddProductPartsAssociated.RowHeadersVisible = false;
            this.dataGridViewAddProductPartsAssociated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddProductPartsAssociated.Size = new System.Drawing.Size(404, 150);
            this.dataGridViewAddProductPartsAssociated.TabIndex = 29;
            this.dataGridViewAddProductPartsAssociated.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddProductPartsAssociated_CellClick);
            this.dataGridViewAddProductPartsAssociated.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AssociatedPartDataBindingComplete);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Add Product";
            // 
            // ProductAllPartsSearchBtn
            // 
            this.ProductAllPartsSearchBtn.Location = new System.Drawing.Point(488, 29);
            this.ProductAllPartsSearchBtn.Name = "ProductAllPartsSearchBtn";
            this.ProductAllPartsSearchBtn.Size = new System.Drawing.Size(52, 23);
            this.ProductAllPartsSearchBtn.TabIndex = 31;
            this.ProductAllPartsSearchBtn.Text = "Search";
            this.ProductAllPartsSearchBtn.UseVisualStyleBackColor = true;
            this.ProductAllPartsSearchBtn.Click += new System.EventHandler(this.ProductAllPartsSearchBtn_Click);
            // 
            // ProductAllPartsLbl
            // 
            this.ProductAllPartsLbl.AutoSize = true;
            this.ProductAllPartsLbl.Location = new System.Drawing.Point(346, 52);
            this.ProductAllPartsLbl.Name = "ProductAllPartsLbl";
            this.ProductAllPartsLbl.Size = new System.Drawing.Size(45, 13);
            this.ProductAllPartsLbl.TabIndex = 32;
            this.ProductAllPartsLbl.Text = "All Parts";
            // 
            // ProductAllPartsSearchTxtBox
            // 
            this.ProductAllPartsSearchTxtBox.Location = new System.Drawing.Point(546, 32);
            this.ProductAllPartsSearchTxtBox.Name = "ProductAllPartsSearchTxtBox";
            this.ProductAllPartsSearchTxtBox.Size = new System.Drawing.Size(172, 20);
            this.ProductAllPartsSearchTxtBox.TabIndex = 33;
            this.ProductAllPartsSearchTxtBox.TextChanged += new System.EventHandler(this.ProductAllPartsSearchTxtBox_TextChanged);
            this.ProductAllPartsSearchTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductAllPartsSearchTxtBox_KeyPress);
            // 
            // ProductPartsAssociatedLbl
            // 
            this.ProductPartsAssociatedLbl.AutoSize = true;
            this.ProductPartsAssociatedLbl.Location = new System.Drawing.Point(346, 263);
            this.ProductPartsAssociatedLbl.Name = "ProductPartsAssociatedLbl";
            this.ProductPartsAssociatedLbl.Size = new System.Drawing.Size(167, 13);
            this.ProductPartsAssociatedLbl.TabIndex = 34;
            this.ProductPartsAssociatedLbl.Text = "Parts Associated with this Product";
            // 
            // ProductDeleteAssociatedPartBtn
            // 
            this.ProductDeleteAssociatedPartBtn.Location = new System.Drawing.Point(704, 459);
            this.ProductDeleteAssociatedPartBtn.Name = "ProductDeleteAssociatedPartBtn";
            this.ProductDeleteAssociatedPartBtn.Size = new System.Drawing.Size(49, 23);
            this.ProductDeleteAssociatedPartBtn.TabIndex = 35;
            this.ProductDeleteAssociatedPartBtn.Text = "Delete";
            this.ProductDeleteAssociatedPartBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteAssociatedPartBtn.Click += new System.EventHandler(this.ProductDeleteAssociatedPartBtn_Click);
            // 
            // ProductCancelBtn
            // 
            this.ProductCancelBtn.Location = new System.Drawing.Point(704, 502);
            this.ProductCancelBtn.Name = "ProductCancelBtn";
            this.ProductCancelBtn.Size = new System.Drawing.Size(49, 23);
            this.ProductCancelBtn.TabIndex = 36;
            this.ProductCancelBtn.Text = "Cancel";
            this.ProductCancelBtn.UseVisualStyleBackColor = true;
            this.ProductCancelBtn.Click += new System.EventHandler(this.ProductCancelBtn_Click);
            // 
            // ProductSaveBtn
            // 
            this.ProductSaveBtn.Location = new System.Drawing.Point(654, 502);
            this.ProductSaveBtn.Name = "ProductSaveBtn";
            this.ProductSaveBtn.Size = new System.Drawing.Size(44, 23);
            this.ProductSaveBtn.TabIndex = 37;
            this.ProductSaveBtn.Text = "Save";
            this.ProductSaveBtn.UseVisualStyleBackColor = true;
            this.ProductSaveBtn.Click += new System.EventHandler(this.ProductSaveBtn_Click);
            // 
            // ProductAddPartBtn
            // 
            this.ProductAddPartBtn.Location = new System.Drawing.Point(704, 236);
            this.ProductAddPartBtn.Name = "ProductAddPartBtn";
            this.ProductAddPartBtn.Size = new System.Drawing.Size(49, 23);
            this.ProductAddPartBtn.TabIndex = 38;
            this.ProductAddPartBtn.Text = "Add";
            this.ProductAddPartBtn.UseVisualStyleBackColor = true;
            this.ProductAddPartBtn.Click += new System.EventHandler(this.ProductAddPartBtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 558);
            this.Controls.Add(this.ProductAddPartBtn);
            this.Controls.Add(this.ProductSaveBtn);
            this.Controls.Add(this.ProductCancelBtn);
            this.Controls.Add(this.ProductDeleteAssociatedPartBtn);
            this.Controls.Add(this.ProductPartsAssociatedLbl);
            this.Controls.Add(this.ProductAllPartsSearchTxtBox);
            this.Controls.Add(this.ProductAllPartsLbl);
            this.Controls.Add(this.ProductAllPartsSearchBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewAddProductPartsAssociated);
            this.Controls.Add(this.dataGridViewAddProductAllParts);
            this.Controls.Add(this.AddProductMinTextBox);
            this.Controls.Add(this.ProductMinLbl);
            this.Controls.Add(this.AddProductMaxTextBox);
            this.Controls.Add(this.AddProductPriceTextBox);
            this.Controls.Add(this.AddProductInventoryTextBox);
            this.Controls.Add(this.AddProductNameTextBox);
            this.Controls.Add(this.AddProductIDTextBox);
            this.Controls.Add(this.ProductMaxLbl);
            this.Controls.Add(this.ProductPriceLbl);
            this.Controls.Add(this.ProductInventoryLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.ProductIdLbl);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProductAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProductPartsAssociated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddProductMinTextBox;
        private System.Windows.Forms.Label ProductMinLbl;
        private System.Windows.Forms.TextBox AddProductMaxTextBox;
        private System.Windows.Forms.TextBox AddProductPriceTextBox;
        private System.Windows.Forms.TextBox AddProductInventoryTextBox;
        private System.Windows.Forms.TextBox AddProductNameTextBox;
        private System.Windows.Forms.TextBox AddProductIDTextBox;
        private System.Windows.Forms.Label ProductMaxLbl;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Label ProductInventoryLbl;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductIdLbl;
        private System.Windows.Forms.DataGridView dataGridViewAddProductAllParts;
        private System.Windows.Forms.DataGridView dataGridViewAddProductPartsAssociated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ProductAllPartsSearchBtn;
        private System.Windows.Forms.Label ProductAllPartsLbl;
        private System.Windows.Forms.TextBox ProductAllPartsSearchTxtBox;
        private System.Windows.Forms.Label ProductPartsAssociatedLbl;
        private System.Windows.Forms.Button ProductDeleteAssociatedPartBtn;
        private System.Windows.Forms.Button ProductCancelBtn;
        private System.Windows.Forms.Button ProductSaveBtn;
        private System.Windows.Forms.Button ProductAddPartBtn;
    }
}