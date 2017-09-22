namespace ExcelSoft.MasterSetup
{
    partial class ProductGroup
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
            this.ProductGroupGrp = new System.Windows.Forms.GroupBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.CategoryCmb = new System.Windows.Forms.ComboBox();
            this.GroupNameTxt = new System.Windows.Forms.TextBox();
            this.GroupNamelbl = new System.Windows.Forms.Label();
            this.GroupCodeTxt = new System.Windows.Forms.TextBox();
            this.GroupCodelbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.ProductGroupGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGroupGrp
            // 
            this.ProductGroupGrp.Controls.Add(this.SaveBtn);
            this.ProductGroupGrp.Controls.Add(this.ClearBtn);
            this.ProductGroupGrp.Controls.Add(this.LinePanel);
            this.ProductGroupGrp.Controls.Add(this.categoryLbl);
            this.ProductGroupGrp.Controls.Add(this.CategoryCmb);
            this.ProductGroupGrp.Controls.Add(this.GroupNameTxt);
            this.ProductGroupGrp.Controls.Add(this.GroupNamelbl);
            this.ProductGroupGrp.Controls.Add(this.GroupCodeTxt);
            this.ProductGroupGrp.Controls.Add(this.GroupCodelbl);
            this.ProductGroupGrp.Location = new System.Drawing.Point(12, 12);
            this.ProductGroupGrp.Name = "ProductGroupGrp";
            this.ProductGroupGrp.Size = new System.Drawing.Size(1150, 575);
            this.ProductGroupGrp.TabIndex = 0;
            this.ProductGroupGrp.TabStop = false;
            this.ProductGroupGrp.Text = "Product Group";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.Black;
            this.categoryLbl.Location = new System.Drawing.Point(748, 94);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(59, 16);
            this.categoryLbl.TabIndex = 121;
            this.categoryLbl.Text = "Category";
            // 
            // CategoryCmb
            // 
            this.CategoryCmb.BackColor = System.Drawing.Color.White;
            this.CategoryCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCmb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCmb.ForeColor = System.Drawing.Color.Black;
            this.CategoryCmb.FormattingEnabled = true;
            this.CategoryCmb.Location = new System.Drawing.Point(885, 94);
            this.CategoryCmb.Margin = new System.Windows.Forms.Padding(1);
            this.CategoryCmb.Name = "CategoryCmb";
            this.CategoryCmb.Size = new System.Drawing.Size(236, 24);
            this.CategoryCmb.TabIndex = 122;
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.BackColor = System.Drawing.Color.White;
            this.GroupNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupNameTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameTxt.ForeColor = System.Drawing.Color.Black;
            this.GroupNameTxt.Location = new System.Drawing.Point(483, 92);
            this.GroupNameTxt.Margin = new System.Windows.Forms.Padding(1);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.ReadOnly = true;
            this.GroupNameTxt.Size = new System.Drawing.Size(225, 23);
            this.GroupNameTxt.TabIndex = 117;
            // 
            // GroupNamelbl
            // 
            this.GroupNamelbl.AutoSize = true;
            this.GroupNamelbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNamelbl.ForeColor = System.Drawing.Color.Black;
            this.GroupNamelbl.Location = new System.Drawing.Point(375, 94);
            this.GroupNamelbl.Name = "GroupNamelbl";
            this.GroupNamelbl.Size = new System.Drawing.Size(79, 16);
            this.GroupNamelbl.TabIndex = 115;
            this.GroupNamelbl.Text = "Group Name";
            // 
            // GroupCodeTxt
            // 
            this.GroupCodeTxt.BackColor = System.Drawing.Color.White;
            this.GroupCodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupCodeTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCodeTxt.ForeColor = System.Drawing.Color.Black;
            this.GroupCodeTxt.Location = new System.Drawing.Point(112, 92);
            this.GroupCodeTxt.Margin = new System.Windows.Forms.Padding(1);
            this.GroupCodeTxt.Name = "GroupCodeTxt";
            this.GroupCodeTxt.ReadOnly = true;
            this.GroupCodeTxt.Size = new System.Drawing.Size(225, 23);
            this.GroupCodeTxt.TabIndex = 116;
            // 
            // GroupCodelbl
            // 
            this.GroupCodelbl.AutoSize = true;
            this.GroupCodelbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCodelbl.ForeColor = System.Drawing.Color.Black;
            this.GroupCodelbl.Location = new System.Drawing.Point(6, 94);
            this.GroupCodelbl.Name = "GroupCodelbl";
            this.GroupCodelbl.Size = new System.Drawing.Size(79, 16);
            this.GroupCodelbl.TabIndex = 114;
            this.GroupCodelbl.Text = "Group Code ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(9, 35);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(114, 33);
            this.SaveBtn.TabIndex = 140;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.ClearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(129, 35);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(114, 33);
            this.ClearBtn.TabIndex = 141;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.LightBlue;
            this.LinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinePanel.Location = new System.Drawing.Point(9, 74);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(1141, 2);
            this.LinePanel.TabIndex = 139;
            // 
            // ProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 587);
            this.Controls.Add(this.ProductGroupGrp);
            this.Name = "ProductGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductGroup";
            this.Load += new System.EventHandler(this.ProductGroup_Load);
            this.ProductGroupGrp.ResumeLayout(false);
            this.ProductGroupGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductGroupGrp;
        private System.Windows.Forms.TextBox GroupNameTxt;
        private System.Windows.Forms.Label GroupNamelbl;
        private System.Windows.Forms.TextBox GroupCodeTxt;
        private System.Windows.Forms.Label GroupCodelbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox CategoryCmb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel LinePanel;
    }
}