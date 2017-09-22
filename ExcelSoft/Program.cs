using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSoft
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        public static void BindDropdown(System.Windows.Forms.ComboBox comboBox, System.Data.DataTable table, string valueField, string textField, bool hasSelect)
        {
            try
            {
                if (hasSelect)
                {
                    DataRow datarow = table.NewRow();
                    datarow[textField] = "--Select--";
                    datarow[valueField] = "0";
                    table.Rows.InsertAt(datarow, 0);
                }
                comboBox.DataSource = table.DefaultView;
                comboBox.ValueMember = valueField;
                comboBox.DisplayMember = textField;
                comboBox.SelectedValue = 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
