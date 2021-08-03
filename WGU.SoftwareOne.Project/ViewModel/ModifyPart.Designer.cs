
namespace WGU.SoftwareOne.Project.ViewModel
{
    partial class ModifyPart
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
            this.ModifyPartSaveBtn = new System.Windows.Forms.Button();
            this.ModifyPartCancelBtn = new System.Windows.Forms.Button();
            this.ModifyPartDynamicTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartIDTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartOutsourcedBtn = new System.Windows.Forms.RadioButton();
            this.ModifyPartInHousedBtn = new System.Windows.Forms.RadioButton();
            this.ModifyPartDynamicLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyPartLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyPartSaveBtn
            // 
            this.ModifyPartSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartSaveBtn.Location = new System.Drawing.Point(320, 268);
            this.ModifyPartSaveBtn.Name = "ModifyPartSaveBtn";
            this.ModifyPartSaveBtn.Size = new System.Drawing.Size(56, 32);
            this.ModifyPartSaveBtn.TabIndex = 37;
            this.ModifyPartSaveBtn.Text = "Save";
            this.ModifyPartSaveBtn.UseVisualStyleBackColor = true;
            this.ModifyPartSaveBtn.Click += new System.EventHandler(this.ModifyPartSaveBtn_Click);
            // 
            // ModifyPartCancelBtn
            // 
            this.ModifyPartCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartCancelBtn.Location = new System.Drawing.Point(382, 268);
            this.ModifyPartCancelBtn.Name = "ModifyPartCancelBtn";
            this.ModifyPartCancelBtn.Size = new System.Drawing.Size(65, 32);
            this.ModifyPartCancelBtn.TabIndex = 36;
            this.ModifyPartCancelBtn.Text = "Cancel";
            this.ModifyPartCancelBtn.UseVisualStyleBackColor = true;
            this.ModifyPartCancelBtn.Click += new System.EventHandler(this.ModifyPartCancelBtn_Click);
            // 
            // ModifyPartDynamicTextBox
            // 
            this.ModifyPartDynamicTextBox.Location = new System.Drawing.Point(137, 229);
            this.ModifyPartDynamicTextBox.Name = "ModifyPartDynamicTextBox";
            this.ModifyPartDynamicTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModifyPartDynamicTextBox.TabIndex = 35;
            this.ModifyPartDynamicTextBox.TextChanged += new System.EventHandler(this.ModifyPartDynamicTextBox_TextChanged);
            this.ModifyPartDynamicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartDynamicTextBox_KeyPress);
            // 
            // ModifyPartMinTextBox
            // 
            this.ModifyPartMinTextBox.Location = new System.Drawing.Point(347, 199);
            this.ModifyPartMinTextBox.Name = "ModifyPartMinTextBox";
            this.ModifyPartMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyPartMinTextBox.TabIndex = 34;
            this.ModifyPartMinTextBox.TextChanged += new System.EventHandler(this.ModifyPartMinTextBox_TextChanged);
            this.ModifyPartMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartMinTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Min";
            // 
            // ModifyPartMaxTextBox
            // 
            this.ModifyPartMaxTextBox.Location = new System.Drawing.Point(137, 199);
            this.ModifyPartMaxTextBox.Name = "ModifyPartMaxTextBox";
            this.ModifyPartMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyPartMaxTextBox.TabIndex = 32;
            this.ModifyPartMaxTextBox.TextChanged += new System.EventHandler(this.ModifyPartMaxTextBox_TextChanged);
            this.ModifyPartMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartMaxTextBox_KeyPress);
            // 
            // ModifyPartPriceTextBox
            // 
            this.ModifyPartPriceTextBox.Location = new System.Drawing.Point(137, 170);
            this.ModifyPartPriceTextBox.Name = "ModifyPartPriceTextBox";
            this.ModifyPartPriceTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModifyPartPriceTextBox.TabIndex = 31;
            this.ModifyPartPriceTextBox.TextChanged += new System.EventHandler(this.ModifyPartPriceTextBox_TextChanged);
            this.ModifyPartPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartPriceTextBox_KeyPress);
            // 
            // ModifyPartInventoryTextBox
            // 
            this.ModifyPartInventoryTextBox.Location = new System.Drawing.Point(137, 138);
            this.ModifyPartInventoryTextBox.Name = "ModifyPartInventoryTextBox";
            this.ModifyPartInventoryTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModifyPartInventoryTextBox.TabIndex = 30;
            this.ModifyPartInventoryTextBox.TextChanged += new System.EventHandler(this.ModifyPartInventoryTextBox_TextChanged);
            this.ModifyPartInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartInventoryTextBox_KeyPress);
            // 
            // ModifyPartNameTextBox
            // 
            this.ModifyPartNameTextBox.Location = new System.Drawing.Point(137, 104);
            this.ModifyPartNameTextBox.Name = "ModifyPartNameTextBox";
            this.ModifyPartNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModifyPartNameTextBox.TabIndex = 29;
            this.ModifyPartNameTextBox.TextChanged += new System.EventHandler(this.ModifyPartNameTextBox_TextChanged);
            // 
            // ModifyPartIDTextBox
            // 
            this.ModifyPartIDTextBox.Enabled = false;
            this.ModifyPartIDTextBox.Location = new System.Drawing.Point(137, 71);
            this.ModifyPartIDTextBox.Name = "ModifyPartIDTextBox";
            this.ModifyPartIDTextBox.ReadOnly = true;
            this.ModifyPartIDTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModifyPartIDTextBox.TabIndex = 28;
            // 
            // ModifyPartOutsourcedBtn
            // 
            this.ModifyPartOutsourcedBtn.AutoSize = true;
            this.ModifyPartOutsourcedBtn.Location = new System.Drawing.Point(261, 29);
            this.ModifyPartOutsourcedBtn.Name = "ModifyPartOutsourcedBtn";
            this.ModifyPartOutsourcedBtn.Size = new System.Drawing.Size(80, 17);
            this.ModifyPartOutsourcedBtn.TabIndex = 27;
            this.ModifyPartOutsourcedBtn.Text = "Outsourced";
            this.ModifyPartOutsourcedBtn.UseVisualStyleBackColor = true;
            this.ModifyPartOutsourcedBtn.CheckedChanged += new System.EventHandler(this.ModifyPartOutsourcedBtn_CheckedChanged);
            // 
            // ModifyPartInHousedBtn
            // 
            this.ModifyPartInHousedBtn.AutoSize = true;
            this.ModifyPartInHousedBtn.Location = new System.Drawing.Point(128, 29);
            this.ModifyPartInHousedBtn.Name = "ModifyPartInHousedBtn";
            this.ModifyPartInHousedBtn.Size = new System.Drawing.Size(68, 17);
            this.ModifyPartInHousedBtn.TabIndex = 26;
            this.ModifyPartInHousedBtn.Text = "In-House";
            this.ModifyPartInHousedBtn.UseVisualStyleBackColor = true;
            this.ModifyPartInHousedBtn.CheckedChanged += new System.EventHandler(this.ModifyPartInHousedBtn_CheckedChanged);
            // 
            // ModifyPartDynamicLbl
            // 
            this.ModifyPartDynamicLbl.AutoSize = true;
            this.ModifyPartDynamicLbl.Location = new System.Drawing.Point(49, 229);
            this.ModifyPartDynamicLbl.Name = "ModifyPartDynamicLbl";
            this.ModifyPartDynamicLbl.Size = new System.Drawing.Size(0, 13);
            this.ModifyPartDynamicLbl.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price / Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // ModifyPartLbl
            // 
            this.ModifyPartLbl.AutoSize = true;
            this.ModifyPartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLbl.Location = new System.Drawing.Point(12, 26);
            this.ModifyPartLbl.Name = "ModifyPartLbl";
            this.ModifyPartLbl.Size = new System.Drawing.Size(79, 17);
            this.ModifyPartLbl.TabIndex = 19;
            this.ModifyPartLbl.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 360);
            this.Controls.Add(this.ModifyPartSaveBtn);
            this.Controls.Add(this.ModifyPartCancelBtn);
            this.Controls.Add(this.ModifyPartDynamicTextBox);
            this.Controls.Add(this.ModifyPartMinTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModifyPartMaxTextBox);
            this.Controls.Add(this.ModifyPartPriceTextBox);
            this.Controls.Add(this.ModifyPartInventoryTextBox);
            this.Controls.Add(this.ModifyPartNameTextBox);
            this.Controls.Add(this.ModifyPartIDTextBox);
            this.Controls.Add(this.ModifyPartOutsourcedBtn);
            this.Controls.Add(this.ModifyPartInHousedBtn);
            this.Controls.Add(this.ModifyPartDynamicLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyPartLbl);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyPartSaveBtn;
        private System.Windows.Forms.Button ModifyPartCancelBtn;
        private System.Windows.Forms.TextBox ModifyPartDynamicTextBox;
        private System.Windows.Forms.TextBox ModifyPartMinTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModifyPartMaxTextBox;
        private System.Windows.Forms.TextBox ModifyPartPriceTextBox;
        private System.Windows.Forms.TextBox ModifyPartInventoryTextBox;
        private System.Windows.Forms.TextBox ModifyPartNameTextBox;
        private System.Windows.Forms.TextBox ModifyPartIDTextBox;
        private System.Windows.Forms.RadioButton ModifyPartOutsourcedBtn;
        private System.Windows.Forms.RadioButton ModifyPartInHousedBtn;
        private System.Windows.Forms.Label ModifyPartDynamicLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModifyPartLbl;
    }
}