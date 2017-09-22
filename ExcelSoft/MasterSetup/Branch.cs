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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
            this.Text = "Branch - ( New )";
            BranchGrp.Location = new Point(
             this.ClientSize.Width / 2 - BranchGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - BranchGrp.Size.Height / 2);
            BranchGrp.Anchor = AnchorStyles.None;
        }

        private void Branch_Load(object sender, EventArgs e)
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
