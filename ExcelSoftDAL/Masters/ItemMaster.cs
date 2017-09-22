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
    public class ItemMaster:DataAccess
    {
        private string _sql;
        private DataSet _dataSet;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public ItemMaster():base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
        }

        public string SaveItemMaster(IItemMaster _item)
        {
            try
            {
                _sql = "SaveItemMaster";
                _parms = new SqlParameter[5];
                _parms[0] = new SqlParameter("@ItemID", SqlDbType.BigInt);
                _parms[0].Value = _item.ItemID;               
                _parms[1] = new SqlParameter("@ItemName", SqlDbType.NVarChar);
                _parms[1].Value = _item.ItemName;
                _parms[2] = new SqlParameter("@CategoryID", SqlDbType.Int);
                _parms[2].Value = _item.CategoryID;
                _parms[3] = new SqlParameter("@IsActive", SqlDbType.Bit);
                _parms[3].Value = _item.IsActive;
                _parms[4] = new SqlParameter("ReturnValue", SqlDbType.NVarChar, 255);
                _parms[4].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "ReturnValue", _parms).ToString();
            }
            catch
            { throw; }
        }
        public DataSet ShowItems()
        {
            try
            {
                _sql = "ShowItems";
                _dataSet = RunProcedure(_sql, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetItem(IItemMaster _item)
        {
            try
            {
                _sql = "GetItem";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@ItemID", SqlDbType.BigInt);
                _parms[0].Value = _item.ItemID;
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
