using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelSoftFactory.Masters;
using System.Data;

namespace ExcelSoftBAL.Masters
{
    public class Customer:ICustomer
    {
        private int _customerID;
        private string _customerCode;
        private string _customerName;
        private string _address;
        private string _town;
        private string _transportName;
        private long? _mobile1;
        private long? _mobile2;
        private long? _phoneNo;
        private long? _gstNumber;

        public int CustomerID
        {
            get
            {
                return _customerID;
            }

            set
            {
                _customerID = value;
            }
        }

        public string CustomerCode
        {
            get
            {
                return _customerCode;
            }

            set
            {
                _customerCode = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return _customerName;
            }

            set
            {
                _customerName = value;
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

        public string Town
        {
            get
            {
                return _town;
            }

            set
            {
                _town = value;
            }
        }

        public string TransportName
        {
            get
            {
                return _transportName;
            }

            set
            {
                _transportName = value;
            }
        }

        public long? Mobile1
        {
            get
            {
                return _mobile1;
            }

            set
            {
                _mobile1 = value;
            }
        }

        public long? Mobile2
        {
            get
            {
                return _mobile2;
            }

            set
            {
                _mobile2 = value;
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

        public long? GstNumber
        {
            get
            {
                return _gstNumber;
            }

            set
            {
                _gstNumber = value;
            }
        }

        public string SaveCustomer()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Customer().SaveCustomer(this);
            }
            catch
            { throw; }
        }
        public DataSet ShowCustomers()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Customer().ShowCustomers();
            }
            catch
            { throw; }
        }
         public DataSet GetCustomer()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Customer().GetCustomer(this);
            }
            catch
            { throw; }
        }
    }
}
