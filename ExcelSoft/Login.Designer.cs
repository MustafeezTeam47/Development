namespace ExcelSoft
{
    partial class Login
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
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.LoginCmd = new System.Windows.Forms.Button();
            this.CancelCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxt.Location = new System.Drawing.Point(153, 85);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(246, 23);
            this.PasswordTxt.TabIndex = 14;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.White;
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.Color.Black;
            this.UserNameTxt.Location = new System.Drawing.Point(153, 48);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(246, 23);
            this.UserNameTxt.TabIndex = 13;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.Black;
            this.PasswordLbl.Location = new System.Drawing.Point(44, 87);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(63, 16);
            this.PasswordLbl.TabIndex = 11;
            this.PasswordLbl.Text = "Password";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.Color.Black;
            this.UserNameLbl.Location = new System.Drawing.Point(44, 52);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(71, 16);
            this.UserNameLbl.TabIndex = 10;
            this.UserNameLbl.Text = "User Name";
            // 
            // LoginCmd
            // 
            this.LoginCmd.AutoEllipsis = true;
            this.LoginCmd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginCmd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.LoginCmd.FlatAppearance.BorderSize = 0;
            this.LoginCmd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.LoginCmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.LoginCmd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCmd.ForeColor = System.Drawing.Color.Black;
            this.LoginCmd.Location = new System.Drawing.Point(152, 131);
            this.LoginCmd.Name = "LoginCmd";
            this.LoginCmd.Size = new System.Drawing.Size(98, 33);
            this.LoginCmd.TabIndex = 16;
            this.LoginCmd.Text = "Login";
            this.LoginCmd.UseVisualStyleBackColor = false;
            this.LoginCmd.Click += new System.EventHandler(this.LoginCmd_Click);
            // 
            // CancelCmd
            // 
            this.CancelCmd.AutoEllipsis = true;
            this.CancelCmd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelCmd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCmd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.CancelCmd.FlatAppearance.BorderSize = 0;
            this.CancelCmd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.CancelCmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.CancelCmd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCmd.ForeColor = System.Drawing.Color.Black;
            this.CancelCmd.Location = new System.Drawing.Point(257, 131);
            this.CancelCmd.Name = "CancelCmd";
            this.CancelCmd.Size = new System.Drawing.Size(98, 33);
            this.CancelCmd.TabIndex = 17;
            this.CancelCmd.Text = "Cancel";
            this.CancelCmd.UseVisualStyleBackColor = false;
            this.CancelCmd.Click += new System.EventHandler(this.CancelCmd_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginCmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCmd;
            this.ClientSize = new System.Drawing.Size(443, 197);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.LoginCmd);
            this.Controls.Add(this.CancelCmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Button LoginCmd;
        private System.Windows.Forms.Button CancelCmd;
    }
}