using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.UserNameTxt.Text == "")
                {
                    MessageBox.Show(ApplicationUtility.Utility.MessageDictionary["EnterUsername"].ToString());

                    this.UserNameTxt.Focus();
                    return;
                }
                else if (this.PasswordTxt.Text == "")
                {
                    MessageBox.Show(ApplicationUtility.Utility.MessageDictionary["EnterPassword"].ToString());

                    this.PasswordTxt.Focus();
                    return;
                }
                MainFormMDI _mainForm= new MainFormMDI();
                _mainForm.Show();
                this.Hide();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void CancelCmd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
