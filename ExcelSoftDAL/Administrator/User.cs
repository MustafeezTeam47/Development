using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationUtility;
using ExcelSoftFactory.Administrator;
using System.Data;
using System.Data.SqlClient;

namespace ExcelSoftDAL.Administrator
{
    public class User:DataAccess
    {
        private string _sql;
        private DataSet _dataSet;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public User():base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
        }
        public string SaveUser(ExcelSoftFactory.Administrator.IUser _user)
        {
            try
            {
                _sql = "SaveUser";
                _parms = new SqlParameter[6];
                _parms[0] = new SqlParameter("@UserID", SqlDbType.BigInt);
                _parms[0].Value = _user.UserID;
                _parms[1] = new SqlParameter("@UserName", SqlDbType.NVarChar);
                _parms[1].Value = _user.UserName;
                _parms[2] = new SqlParameter("@Password", SqlDbType.NVarChar);
                _parms[2].Value = _user.Password;
                _parms[3] = new SqlParameter("@RoleID", SqlDbType.Int);
                _parms[3].Value = _user.RoleID;
                //_parms[4] = new SqlParameter("@MobileNo", SqlDbType.BigInt);
                //_parms[4].Value = _user.MobileNo;
                //_parms[5] = new SqlParameter("@PhoneNo", SqlDbType.BigInt);
                //_parms[5].Value = _user.PhoneNo;
                _parms[4] = new SqlParameter("@IsActive", SqlDbType.Bit);
                _parms[4].Value = _user.IsActive;
                _parms[5] = new SqlParameter("ReturnValue", SqlDbType.NVarChar, 255);
                _parms[5].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "ReturnValue", _parms).ToString();
            }
            catch
            { throw; }
        }
        public DataSet ShowUser()
        {
            try
            {
                _sql = "ShowUsers";
                _dataSet = RunProcedure(_sql, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetUser(ExcelSoftFactory.Administrator.IUser _user)
        {
            try
            {
                _sql = "GetUser";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@UserID", SqlDbType.BigInt);
                _parms[0].Value = _user.UserID;
                _dataSet = RunProcedure(_sql, _parms, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
    }
}
