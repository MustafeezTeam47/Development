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
    public partial class PurchaseReturn : Form
    {
        DataRow _datarowmain, _itemDatarow;
        private DataTable _datatable;
        public PurchaseReturn()
        {
            InitializeComponent();
            this.Text = "Purchase Return - ( New )";
            PurchaseReturnGrp.Location = new Point(
             this.ClientSize.Width / 2 - PurchaseReturnGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - PurchaseReturnGrp.Size.Height / 2);
            PurchaseReturnGrp.Anchor = AnchorStyles.None;
        }
        public void GetMainGridTable()
        {
            _datatable = new DataTable("Datatable");
            //  _datatable.Columns.Add("itemid", typeof(int));
            _datatable.Columns.Add("SNO", typeof(int));
            _datatable.Columns.Add("ProductCode", typeof(string));
            _datatable.Columns.Add("ProductName", typeof(string));

            _datatable.Columns.Add("Unit", typeof(decimal));
            _datatable.Columns.Add("ReturningQuantity", typeof(decimal));
            _datatable.Columns.Add("RecievedQuantity", typeof(decimal));
            _datatable.Columns.Add("Quantity", typeof(decimal));
            _datatable.Columns.Add("ReturnedQuantity", typeof(decimal));

            _datatable.Columns.Add("Cost", typeof(decimal));

            _datatable.Columns.Add("TotalCost", typeof(decimal));
          //  _datatable.Columns.Add("Action", typeof(decimal));
            //_datatable.Columns.Add("UnitId", typeof(int));
        }
        private void AddNewRow()
        {
            _datarowmain = _datatable.NewRow();
            //  _datarowmain["itemid"] = 0;
            _datarowmain["SNO"] = _datatable.Rows.Count + 1;
            _datarowmain["ProductCode"] = "";
            _datarowmain["ProductName"] = "";
            _datarowmain["Unit"] = 0.00;
            _datarowmain["ReturningQuantity"] = 0.00;
            _datarowmain["RecievedQuantity"] = 0.00;
            _datarowmain["Quantity"] = 0.00;
            _datarowmain["ReturnedQuantity"] = 0.00;
            _datarowmain["Cost"] = 0.00;
            _datarowmain["TotalCost"] = 0.00;

           // _datarowmain["Action"] = 0.00;
            //  _datarowmain["UnitId"] = 1;
            _datatable.Rows.Add(_datarowmain);
            this.PurchaseRetrunGrid.DataSource = _datatable;
        }
        private decimal RoundDecimalValue(decimal Value)
        {
            return Convert.ToDecimal(string.Format("{0:F}", Value));
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            GetMainGridTable();
            AddNewRow();
        }
    }
}
