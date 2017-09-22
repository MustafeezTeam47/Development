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
    public partial class PurchaseRequest : Form
    {
        DataRow _datarowmain, _itemDatarow;
        private DataTable _datatable;
        public PurchaseRequest()
        {
            InitializeComponent();
            this.Text = "Purchase Request - ( New )";
            PurchaseRequestGrp.Location = new Point(
             this.ClientSize.Width / 2 - PurchaseRequestGrp.Size.Width / 2,
             this.ClientSize.Height / 2 - PurchaseRequestGrp.Size.Height / 2);
            PurchaseRequestGrp.Anchor = AnchorStyles.None;
        }

        private void PurchaseRequest_Load(object sender, EventArgs e)
        {
            GetMainGridTable();
            AddNewRow();
        }
        public void GetMainGridTable()
        {
            _datatable = new DataTable("Datatable");
          //  _datatable.Columns.Add("itemid", typeof(int));
            _datatable.Columns.Add("SNO", typeof(int));
            _datatable.Columns.Add("ProductCode", typeof(string));
            _datatable.Columns.Add("ProductName", typeof(string));

            _datatable.Columns.Add("Unit", typeof(decimal));
            _datatable.Columns.Add("Quantity", typeof(decimal));

           
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
            _datarowmain["Quantity"] = 0.00;
            _datarowmain["Cost"] = 0.00;
            _datarowmain["TotalCost"] = 0.00;
       //     _datarowmain["Action"] = 0.00;
            //  _datarowmain["UnitId"] = 1;
            _datatable.Rows.Add(_datarowmain);
            this.PurchaseRequestGrid.DataSource = _datatable;
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
    }
}
