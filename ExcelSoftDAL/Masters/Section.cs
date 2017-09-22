using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApplicationUtility;
using ExcelSoftFactory.Masters;

namespace ExcelSoftDAL.Masters
{
    public class Section:DataAccess
    {

        private string _sql;
        private DataSet _dataSet;
        private SqlParameter[] _parms;
        private string[] _outParms;

        public Section():base(ApplicationUtility.Utility.ConnectionString)
        {
            _sql = String.Empty;
            _dataSet = new DataSet();
        }
        public string SaveSection(ExcelSoftFactory.Masters.ISection _section)
        {
            try
            {
                _sql = "SaveSection";
                _parms = new SqlParameter[4];
                _parms[0] = new SqlParameter("@SectionID", SqlDbType.BigInt);
                _parms[0].Value = _section.SectionID;              
                _parms[1] = new SqlParameter("@SectionName", SqlDbType.NVarChar);
                _parms[1].Value = _section.SectionName;
                _parms[2] = new SqlParameter("@IsActive", SqlDbType.Bit);
                _parms[2].Value = _section.IsActive;
                _parms[3] = new SqlParameter("ReturnValue", SqlDbType.NVarChar,255);
                _parms[3].Direction = ParameterDirection.Output;
                return RunProcedure(_sql, "ReturnValue", _parms).ToString();
            }
            catch
            { throw; }
        }
        public DataSet ShowSections()
        {
            try
            {
                _sql = "ShowSections";
                _dataSet = RunProcedure(_sql, false);
                return _dataSet;
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetSection(ExcelSoftFactory.Masters.ISection _section)
        {
            try
            {
                _sql = "GetSection";
                _parms = new SqlParameter[1];
                _parms[0] = new SqlParameter("@SectionID", SqlDbType.BigInt);
                _parms[0].Value = _section.SectionID;
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
