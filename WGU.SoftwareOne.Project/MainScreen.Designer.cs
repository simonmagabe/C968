
namespace WGU.SoftwareOne.Project
{
    partial class MainScreen
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
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PartSearchBtn = new System.Windows.Forms.Button();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.partLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.PartAddBtn = new System.Windows.Forms.Button();
            this.PartModifyBtn = new System.Windows.Forms.Button();
            this.PartDeleteBtn = new System.Windows.Forms.Button();
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.ProductModifyBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.mainScreenExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToAddRows = false;
            this.partDataGridView.AllowUserToDeleteRows = false;
            this.partDataGridView.AllowUserToResizeColumns = false;
            this.partDataGridView.AllowUserToResizeRows = false;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.Location = new System.Drawing.Point(25, 96);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.ReadOnly = true;
            this.partDataGridView.RowHeadersVisible = false;
            this.partDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(427, 325);
            this.partDataGridView.TabIndex = 0;
            this.partDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PartGridViewBindingComplete);
            this.partDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartDataGridView_MouseDown);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(517, 96);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(428, 325);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductGridViewBindingComplete);
            this.productDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductDataGridView_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // PartSearchBtn
            // 
            this.PartSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchBtn.Location = new System.Drawing.Point(222, 65);
            this.PartSearchBtn.Name = "PartSearchBtn";
            this.PartSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.PartSearchBtn.TabIndex = 3;
            this.PartSearchBtn.Text = "Search";
            this.PartSearchBtn.UseVisualStyleBackColor = true;
            this.PartSearchBtn.Click += new System.EventHandler(this.PartSearchBtn_Click);
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBtn.Location = new System.Drawing.Point(728, 63);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.ProductSearchBtn.TabIndex = 4;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = true;
            this.ProductSearchBtn.Click += new System.EventHandler(this.ProductSearchBtn_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(303, 65);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(149, 20);
            this.partSearchTextBox.TabIndex = 5;
            this.partSearchTextBox.TextChanged += new System.EventHandler(this.PartSearchTextBox_TextChanged);
            this.partSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartSearchTextBox_KeyPress);
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(809, 65);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(136, 20);
            this.productSearchTextBox.TabIndex = 6;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            this.productSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductSearchTextBox_KeyPress);
            // 
            // partLbl
            // 
            this.partLbl.AutoSize = true;
            this.partLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLbl.Location = new System.Drawing.Point(22, 59);
            this.partLbl.Name = "partLbl";
            this.partLbl.Size = new System.Drawing.Size(38, 20);
            this.partLbl.TabIndex = 7;
            this.partLbl.Text = "Part";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.Location = new System.Drawing.Point(513, 59);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(64, 20);
            this.productLbl.TabIndex = 8;
            this.productLbl.Text = "Product";
            // 
            // PartAddBtn
            // 
            this.PartAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartAddBtn.Location = new System.Drawing.Point(274, 442);
            this.PartAddBtn.Name = "PartAddBtn";
            this.PartAddBtn.Size = new System.Drawing.Size(48, 33);
            this.PartAddBtn.TabIndex = 9;
            this.PartAddBtn.Text = "Add";
            this.PartAddBtn.UseVisualStyleBackColor = true;
            this.PartAddBtn.Click += new System.EventHandler(this.PartAddBtn_Click);
            // 
            // PartModifyBtn
            // 
            this.PartModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartModifyBtn.Location = new System.Drawing.Point(328, 442);
            this.PartModifyBtn.Name = "PartModifyBtn";
            this.PartModifyBtn.Size = new System.Drawing.Size(58, 33);
            this.PartModifyBtn.TabIndex = 10;
            this.PartModifyBtn.Text = "Modify";
            this.PartModifyBtn.UseVisualStyleBackColor = true;
            this.PartModifyBtn.Click += new System.EventHandler(this.PartModifyBtn_Click);
            // 
            // PartDeleteBtn
            // 
            this.PartDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDeleteBtn.Location = new System.Drawing.Point(392, 442);
            this.PartDeleteBtn.Name = "PartDeleteBtn";
            this.PartDeleteBtn.Size = new System.Drawing.Size(60, 33);
            this.PartDeleteBtn.TabIndex = 11;
            this.PartDeleteBtn.Text = "Delete";
            this.PartDeleteBtn.UseVisualStyleBackColor = true;
            this.PartDeleteBtn.Click += new System.EventHandler(this.PartDeleteBtn_Click);
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAddBtn.Location = new System.Drawing.Point(761, 442);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(55, 33);
            this.ProductAddBtn.TabIndex = 12;
            this.ProductAddBtn.Text = "Add";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // ProductModifyBtn
            // 
            this.ProductModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductModifyBtn.Location = new System.Drawing.Point(822, 442);
            this.ProductModifyBtn.Name = "ProductModifyBtn";
            this.ProductModifyBtn.Size = new System.Drawing.Size(59, 33);
            this.ProductModifyBtn.TabIndex = 13;
            this.ProductModifyBtn.Text = "Modify";
            this.ProductModifyBtn.UseVisualStyleBackColor = true;
            this.ProductModifyBtn.Click += new System.EventHandler(this.ProductModifyBtn_Click);
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDeleteBtn.Location = new System.Drawing.Point(887, 442);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(58, 33);
            this.ProductDeleteBtn.TabIndex = 14;
            this.ProductDeleteBtn.Text = "Delete";
            this.ProductDeleteBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // mainScreenExitBtn
            // 
            this.mainScreenExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenExitBtn.Location = new System.Drawing.Point(894, 495);
            this.mainScreenExitBtn.Name = "mainScreenExitBtn";
            this.mainScreenExitBtn.Size = new System.Drawing.Size(51, 36);
            this.mainScreenExitBtn.TabIndex = 15;
            this.mainScreenExitBtn.Text = "Exit";
            this.mainScreenExitBtn.UseVisualStyleBackColor = true;
            this.mainScreenExitBtn.Click += new System.EventHandler(this.MainScreenExitBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 554);
            this.Controls.Add(this.mainScreenExitBtn);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductModifyBtn);
            this.Controls.Add(this.ProductAddBtn);
            this.Controls.Add(this.PartDeleteBtn);
            this.Controls.Add(this.PartModifyBtn);
            this.Controls.Add(this.PartAddBtn);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.partLbl);
            this.Controls.Add(this.productSearchTextBox);
            this.Controls.Add(this.partSearchTextBox);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.PartSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.partDataGridView);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView partDataGridView;
        public System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PartSearchBtn;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Label partLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Button PartAddBtn;
        private System.Windows.Forms.Button PartModifyBtn;
        private System.Windows.Forms.Button PartDeleteBtn;
        private System.Windows.Forms.Button ProductAddBtn;
        private System.Windows.Forms.Button ProductModifyBtn;
        private System.Windows.Forms.Button ProductDeleteBtn;
        private System.Windows.Forms.Button mainScreenExitBtn;
    }
}

