using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelSoftFactory.Administrator;
using ExcelSoftDAL.Administrator;
using System.Data;

namespace ExcelSoftBAL.Administrator
{
   public class User:IUser
    {
        private int _userID;
        private string _userCode;
        private string _userName;
        private string _password;
        private int? _roleID;
        private bool _isActive;
        private long? _mobileNo;
        private long? _phoneNo;
        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }

        public string UserCode
        {
            get
            {
                return _userCode;
            }

            set
            {
                _userCode = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public int? RoleID
        {
            get
            {
                return _roleID;
            }

            set
            {
                _roleID = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }

            set
            {
                _isActive = value;
            }
        }

        public long? MobileNo
        {
            get
            {
                return _mobileNo;
            }

            set
            {
                _mobileNo = value;
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

        public string SaveUser()
        {
            try
            {
                return new ExcelSoftDAL.Administrator.User().SaveUser(this);
            }
            catch
            {
                throw;
            }
        }
        public DataSet ShowUser()
        {
            try
            {
                return new ExcelSoftDAL.Administrator.User().ShowUser();
         
            }
            catch
            { throw; }
        }
        public DataSet GetUser()
        {
            try
            {
                return new ExcelSoftDAL.Administrator.User().GetUser(this);
            }
            catch
            { throw; }
        }
    }
}
