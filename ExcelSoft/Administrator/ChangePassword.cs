using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSoft.Administrator
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.Text = "Change Password - ( New )";
            ChangePasswordGrp.Location = new Point(
             this.ClientSize.Width / 2 - ChangePasswordGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - ChangePasswordGrp.Size.Height / 2);
            ChangePasswordGrp.Anchor = AnchorStyles.None;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
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
