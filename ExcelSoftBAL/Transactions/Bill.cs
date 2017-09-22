using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelSoftFactory.Transactions;
namespace ExcelSoftBAL.Transactions
{
    public class Bill:IBill
    {
        private int _retailID;
        private string _retailNumber;
        private DateTime _retailDate;
        private string _customerName;
        private string _nodeNo;
        private string _transportName;
        private bool _temporaryName;
        private bool _printCompanyName;
        private string _phoneNo;
        private decimal? _discountAmount;
        private decimal? _tax1Amount;
        private decimal? _tax2Amount;
        private decimal? _netTotal;
        private int _payByID;
        private string _headerCaption;
        private decimal? _oldBalance;
        private string _itemXML;

        public int RetailID
        {
            get
            {
                return _retailID;
            }

            set
            {
                _retailID = value;
            }
        }

        public string RetailNumber
        {
            get
            {
                return _retailNumber;
            }

            set
            {
                _retailNumber = value;
            }
        }

        public DateTime RetailDate
        {
            get
            {
                return _retailDate;
            }

            set
            {
                _retailDate = value;
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

        public string NodeNo
        {
            get
            {
                return _nodeNo;
            }

            set
            {
                _nodeNo = value;
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

        public bool TemporaryName
        {
            get
            {
                return _temporaryName;
            }

            set
            {
                _temporaryName = value;
            }
        }

        public bool PrintCompanyName
        {
            get
            {
                return _printCompanyName;
            }

            set
            {
                _printCompanyName = value;
            }
        }

        public string PhoneNo
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

        public decimal? DiscountAmount
        {
            get
            {
                return _discountAmount;
            }

            set
            {
                _discountAmount = value;
            }
        }

        public decimal? Tax1Amount
        {
            get
            {
                return _tax1Amount;
            }

            set
            {
                _tax1Amount = value;
            }
        }

        public decimal? Tax2Amount
        {
            get
            {
                return _tax2Amount;
            }

            set
            {
                _tax2Amount = value;
            }
        }

        public decimal? NetTotal
        {
            get
            {
                return _netTotal;
            }

            set
            {
                _netTotal = value;
            }
        }

        public int PayByID
        {
            get
            {
                return _payByID;
            }

            set
            {
                _payByID = value;
            }
        }

        public string HeaderCaption
        {
            get
            {
                return _headerCaption;
            }

            set
            {
                _headerCaption = value;
            }
        }

        public decimal? OldBalance
        {
            get
            {
                return _oldBalance;
            }

            set
            {
                _oldBalance = value;
            }
        }

        public string ItemXML
        {
            get
            {
                return _itemXML;
            }

            set
            {
                _itemXML = value;
            }
        }
    }
}
