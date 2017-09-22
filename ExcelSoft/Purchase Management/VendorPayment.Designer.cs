namespace ExcelSoft.Purchase_Management
{
    partial class VendorPayment
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
            this.VendorPaymentGrp = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // VendorPaymentGrp
            // 
            this.VendorPaymentGrp.Location = new System.Drawing.Point(12, 12);
            this.VendorPaymentGrp.Name = "VendorPaymentGrp";
            this.VendorPaymentGrp.Size = new System.Drawing.Size(1160, 575);
            this.VendorPaymentGrp.TabIndex = 0;
            this.VendorPaymentGrp.TabStop = false;
            // 
            // VendorPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 587);
            this.Controls.Add(this.VendorPaymentGrp);
            this.Name = "VendorPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VendorPaymentGrp;
    }
}