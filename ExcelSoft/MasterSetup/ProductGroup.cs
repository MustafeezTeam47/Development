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
    public partial class ProductGroup : Form
    {
        public ProductGroup()
        {
            InitializeComponent();
            this.Text = "Product Group - ( New )";
            ProductGroupGrp.Location = new Point(
             this.ClientSize.Width / 2 - ProductGroupGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - ProductGroupGrp.Size.Height / 2);
            ProductGroupGrp.Anchor = AnchorStyles.None;
        }

        private void ProductGroup_Load(object sender, EventArgs e)
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
