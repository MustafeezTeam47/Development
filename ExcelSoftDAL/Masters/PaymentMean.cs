using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationUtility;
using System.Data;
using System.Data.SqlClient;
using ExcelSoftFactory.Masters;

namespace ExcelSoftDAL.Masters
{
    public class PaymentMean:DataAccess
    {
        private string _sql;
        private DataSet _dataSet;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public PaymentMean():base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
        }

        public string SavePaymentMean(ExcelSoftFactory.Masters.IPaymentMean _paymentMean)
        {
            try
            {
                _sql = "SavePaymentMean";
                _parms = new SqlParameter[4];
                _parms[0] = new SqlParameter("@PaymentMeanID", SqlDbType.BigInt);
                _parms[0].Value = _paymentMean.PaymentMeanID;       
                _parms[1] = new SqlParameter("@PaymentMeanName", SqlDbType.NVarChar);
                _parms[1].Value = _paymentMean.PaymentMeanName;     
                _parms[2] = new SqlParameter("@IsActive", SqlDbType.Bit);
                _parms[2].Value = _paymentMean.IsActive;
                _parms[3] = new SqlParameter("ReturnValue", SqlDbType.NVarChar,255);
                _parms[3].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "ReturnValue", _parms).ToString();
            }
            catch
            { throw; }
        }
        public DataSet ShowPaymentMeans()
        {
            try
            {
                _sql = "ShowPaymentMeans";
                _dataSet = RunProcedure(_sql, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetPaymentMean(ExcelSoftFactory.Masters.IPaymentMean _paymentMean)
        {
            try
            {
                _sql = "GetPaymentMean";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@PaymentMeanID", SqlDbType.BigInt);
                _parms[0].Value = _paymentMean.PaymentMeanID;
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
