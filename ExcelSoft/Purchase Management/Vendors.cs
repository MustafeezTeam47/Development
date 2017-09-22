using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSoft.Purchase_Management
{
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();
            
            this.Text = "Vendor - ( New )";
            VendorGrp.Location = new Point(
             this.ClientSize.Width / 2 - VendorGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - VendorGrp.Size.Height / 2);
            VendorGrp.Anchor = AnchorStyles.None;
        }

        private void Vendors_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
