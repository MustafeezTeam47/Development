using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApplicationUtility;
using ExcelSoftFactory;


namespace ExcelSoftDAL.Masters
{
    public class Company:DataAccess
    {
        private string _sql;
        private DataSet _dataSet;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public Company()
            : base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
        }
        public DataSet ShowCompanies()
        {
            try
            {
                _sql = "ShowCompanies";               
                _dataSet=RunProcedure(_sql,true);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public string SaveCompany(ExcelSoftFactory.Masters.ICompany _company)
        {
            try
            {
                _sql = "SaveCompany";
                _parms = new SqlParameter[7];
                _parms[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
                _parms[0].Value = _company.CompanyID;
                _parms[1] = new SqlParameter("@CompanyCode", SqlDbType.NVarChar,20);
                _parms[1].Value = _company.CompanyCode;
                _parms[2] = new SqlParameter("@CompanyName", SqlDbType.NVarChar, 255);
                _parms[2].Value = _company.CompanyName;
                _parms[3] = new SqlParameter("@Address", SqlDbType.NVarChar);
                _parms[3].Value = _company.Address;
                _parms[4] = new SqlParameter("@MobileNo", SqlDbType.BigInt);
                _parms[4].Value = _company.Mobile;
                _parms[5] = new SqlParameter("@PhoneNo", SqlDbType.BigInt);
                _parms[5].Value = _company.PhoneNo;               
                _parms[6] = new SqlParameter("@ReturnValue", SqlDbType.NVarChar, 255);
                _parms[6].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "@ReturnValue", _parms).ToString();
             
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetCompany(ExcelSoftFactory.Masters.ICompany _company)
        {
            try
            {
                _sql = "GetCompany";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
                _parms[0].Value = _company.CompanyID;
                _dataSet = RunProcedure(_sql, _parms, true);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        
    }
}
