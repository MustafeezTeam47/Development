using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationUtility;
using System.Data.SqlClient;
using System.Data;
using ExcelSoftFactory.Masters;

namespace ExcelSoftDAL.Masters
{
    public class Customer:DataAccess
    {
        private string _sql;
        private DataSet _dataSet;
        private DataTable _dataTable;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public Customer():base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
            _dataTable = new DataTable();
        }

        public string SaveCustomer(ICustomer _customer)
        {
            try
            {
                _sql = "SaveCustomer";
                _parms = new SqlParameter[10];
                _parms[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                _parms[0].Value = _customer.CustomerID;
                _parms[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
                _parms[1].Value = _customer.CustomerName;           
                _parms[2] = new SqlParameter("@Address", SqlDbType.NVarChar);
                _parms[2].Value = _customer.Address;
                _parms[3] = new SqlParameter("@Town", SqlDbType.NVarChar);
                _parms[3].Value = _customer.Town;
                _parms[4] = new SqlParameter("@TransportName", SqlDbType.NVarChar);
                _parms[4].Value = _customer.TransportName;
                _parms[5] = new SqlParameter("@Mobile1", SqlDbType.BigInt);
                _parms[5].Value = _customer.Mobile1;
                _parms[6] = new SqlParameter("@Mobile2", SqlDbType.BigInt);
                _parms[6].Value = _customer.Mobile2;
                _parms[7] = new SqlParameter("@PhoneNo", SqlDbType.BigInt);
                _parms[7].Value = _customer.PhoneNo;
                _parms[8] = new SqlParameter("@GstNumber", SqlDbType.BigInt);
                _parms[8].Value = _customer.GstNumber;
                _parms[9] = new SqlParameter("@ReturnValue", SqlDbType.NVarChar, 255);
                _parms[9].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "@ReturnValue", _parms).ToString();
            }
            catch
            {
                throw;
            }
        }

        public DataSet ShowCustomers()
        {
            try
            {
                _sql = "ShowCustomers";
                _dataSet = RunProcedure(_sql, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetCustomer(ExcelSoftFactory.Masters.ICustomer _customer)
        {
            try
            {
                _sql = "GetCustomer";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                _parms[0].Value = _customer.CustomerID;
                _dataSet = RunProcedure(_sql,_parms, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
    }
}
