using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ExcelSoftDAL.Masters;
using ExcelSoftFactory.Masters;


namespace ExcelSoftBAL.Masters
{
    public class Company:ICompany
    {       
        
        private int _companyID;
        private string _companyCode;
        private string _companyName;
        private string _address;
        private long? _mobile;
        private long? _phoneNo;

        public int CompanyID
        {
            get
            {
                return _companyID;
            }

            set
            {
                _companyID = value;
            }
        }

        public string CompanyCode
        {
            get
            {
                return _companyCode;
            }

            set
            {
                _companyCode = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }

            set
            {
                _companyName = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public long? Mobile
        {
            get
            {
                return _mobile;
            }

            set
            {
                _mobile = value;
            }
        }

        public long? PhoneNo
        {
            get
            {
                return _phoneNo;
            }

            set
            {
                _phoneNo = value;
            }
        }

        public DataSet ShowCompanies()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Company().ShowCompanies();
            }
            catch
            {
                throw;
            }
        }

        public string SaveCompany()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Company().SaveCompany(this);
            }
            catch
            {
                throw;
            }
        }

        public DataSet GetCompany()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Company().GetCompany(this);
            }
            catch
            { throw; }
        }
    }
}
