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
    public partial class MainFormMDI : RibbonForm
    {
        public MainFormMDI()
        {
            InitializeComponent();
        }

        private void TabManager_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseRbnBtn_Click(object sender, EventArgs e)
        {
            Purchase_Management.Purchase _purchase = new Purchase_Management.Purchase();
            _purchase.MdiParent = this;
            _purchase.Show();
        }
        private void PurchaseorderRbnBtn_Click(object sender, EventArgs e)
        {
            Purchase_Management.PurchaseOrder _purchase = new Purchase_Management.PurchaseOrder();
            _purchase.MdiParent = this;
            _purchase.Show();
        }

        private void PurchaseRequestRbnbtn_Click(object sender, EventArgs e)
        {
            Purchase_Management.PurchaseRequest _purchase = new Purchase_Management.PurchaseRequest();
            _purchase.MdiParent = this;
            _purchase.Show();
        }
        private void CustomerRbnbtn_Click(object sender, EventArgs e)
        {
            Sales_Management.Customers _customer= new Sales_Management.Customers();
            _customer.MdiParent = this;
            _customer.Show();
        }
        private void VendorRbnbtn_Click(object sender, EventArgs e)
        {
            Purchase_Management.Vendors _vendors = new Purchase_Management.Vendors();
            _vendors.MdiParent = this;
            _vendors.Show();
        }

        private void RetailsRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void RetailReturnRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void stockopeningRbnBtn_Click(object sender, EventArgs e)
        {
            Inventory_Management.StockOpening _stockOpening = new Inventory_Management.StockOpening();
            _stockOpening.MdiParent = this;
            _stockOpening.Show();
        }

        private void stockAdjustRbnBtn_Click(object sender, EventArgs e)
        {
            Inventory_Management.StockAdjustment _stockAdjust = new Inventory_Management.StockAdjustment();
            _stockAdjust.MdiParent = this;
            _stockAdjust.Show();
        }

        private void CountingRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReconcilitionRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void AutoOrderRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void BatchesRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseReturnRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void VendorPaymentRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRbnBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void SalesOrderRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalesRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalesReturnRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void RecieptRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void COARbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void JournalEntryRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void YearCloseRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurationRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void RolesRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void BranchRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductCatRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductGrp_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseRequestRbnBtn_Click_1(object sender, EventArgs e)
        {
            Purchase_Management.PurchaseRequest _purchaseRequest = new Purchase_Management.PurchaseRequest();
            _purchaseRequest.MdiParent = this;
            _purchaseRequest.Show();
        }

        private void PurchaseOrderRbnBtn_Click_1(object sender, EventArgs e)
        {
            Purchase_Management.PurchaseOrder _purchaseOrder = new Purchase_Management.PurchaseOrder();
            _purchaseOrder.MdiParent = this;
            _purchaseOrder.Show();
        }

        private void PurchaseRbnBtn_Click_1(object sender, EventArgs e)
        {
            Purchase_Management.Purchase _purchase = new Purchase_Management.Purchase();
            _purchase.MdiParent = this;
            _purchase.Show();
        }

        private void PurchaseReturnRbnBtn_Click_1(object sender, EventArgs e)
        {
            Purchase_Management.PurchaseReturn _purchaseReturn = new Purchase_Management.PurchaseReturn();
            _purchaseReturn.MdiParent = this;
            _purchaseReturn.Show();
        }

        private void VendorPaymentRbnBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRbnBtn_Click_2(object sender, EventArgs e)
        {
            Sales_Management.Customers _customer = new Sales_Management.Customers();
            _customer.MdiParent = this;
            _customer.Show();
        }

        private void SalesOrderRbnBtn_Click_1(object sender, EventArgs e)
        {
            Sales_Management.SalesOrder _salesOrder = new Sales_Management.SalesOrder();
            _salesOrder.MdiParent = this;
            _salesOrder.Show();
        }

        private void SalesRbnBtn_Click_1(object sender, EventArgs e)
        {
            Sales_Management.Sales _sales = new Sales_Management.Sales();
            _sales.MdiParent = this;
            _sales.Show();
        }

        private void SalesReturnRbnBtn_Click_1(object sender, EventArgs e)
        {
            Sales_Management.SalesReturn _salesReturn = new Sales_Management.SalesReturn();
            _salesReturn.MdiParent = this;
            _salesReturn.Show();
        }

        private void ReiceptRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void COARbnBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void JournalEntryRbnBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void YearClosingRbnBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductCatRbnBtn_Click_1(object sender, EventArgs e)
        {
            MasterSetup.ProductCategory _productCat = new MasterSetup.ProductCategory();
            _productCat.MdiParent = this;
            _productCat.Show();
        }

        private void ProductGrpRbnBtn_Click(object sender, EventArgs e)
        {
            MasterSetup.ProductGroup _productGrp = new MasterSetup.ProductGroup();
            _productGrp.MdiParent = this;
            _productGrp.Show();
        }

        private void BranchRbnBtn_Click_1(object sender, EventArgs e)
        {
            MasterSetup.Branch _branch = new MasterSetup.Branch();
            _branch.MdiParent = this;
            _branch.Show();
        }

        private void ChangePwdRbnBtn_Click(object sender, EventArgs e)
        {
            Administrator.ChangePassword _changepwd = new Administrator.ChangePassword();
            _changepwd.MdiParent = this;
            _changepwd.Show();
        }

        private void ProductRbnBtn_Click(object sender, EventArgs e)
        {
            MasterSetup.ProductMaster _product = new MasterSetup.ProductMaster();
            _product.MdiParent = this;
            _product.Show();
        }
    }
}
