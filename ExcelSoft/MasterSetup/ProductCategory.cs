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
    public partial class ProductCategory : Form
    {
        public ProductCategory()
        {
            InitializeComponent();
            this.Text = "Category - ( New )";
            ProductCategoryGrp.Location = new Point(
             this.ClientSize.Width / 2 - ProductCategoryGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - ProductCategoryGrp.Size.Height / 2);
            ProductCategoryGrp.Anchor = AnchorStyles.None;
        }

        private void ProductCategory_Load(object sender, EventArgs e)
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
