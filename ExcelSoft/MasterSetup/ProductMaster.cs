using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSoft.MasterSetup
{
    public partial class ProductMaster : Form
    {
        public ProductMaster()
        {
            InitializeComponent();
            this.Text = "Product - ( New )";
            ProductGrp.Location = new Point(
             this.ClientSize.Width / 2 - ProductGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - ProductGrp.Size.Height / 2);
            ProductGrp.Anchor = AnchorStyles.None;

        }

        private void ProductMaster_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void imageUpladImg_Click(object sender, EventArgs e)
        {

        }
    }
}
