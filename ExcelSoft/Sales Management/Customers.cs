using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSoft.Sales_Management
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            this.Text = "Customer - ( New )";
            CustomerGrp.Location = new Point(
            this.ClientSize.Width / 2 - CustomerGrp.Size.Width / 2,
            this.ClientSize.Height / 2 - CustomerGrp.Size.Height / 2);
            CustomerGrp.Anchor = AnchorStyles.None;
        }

        private void Customers_Load(object sender, EventArgs e)
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
