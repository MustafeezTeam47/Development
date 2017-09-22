using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ApplicationUtility
{
    public class Utility
    {
        private static string _connectionString;
        private static string _reportConnectionString;
        private static string _companyName;
        private static string _firstAddress;
        private static string _secondAddress;
        private static string _cityName;
        private static string _countryName;
        private static string _zipCode;
        private static string _phoneNumnber;
        private static string _dateFormat;
        private static string _logoImage;
        private static string _calendarImage;
        private static string _reportImage;
        private static string _hrmsLink;
        private static string _redirectPath;
        private static string _negativeSign;
        private static Dictionary<string, string> _messageDictionary;
        private static string _creditCardKey;
        private static string _creditCardPin;
        private static string _hacKey;
        private static string _hacPin;
        private static string _yodleeRestURL;
        private static string _cobrandLogin;
        private static string _cobrandPassword;
        private static string _yodleeLogin;
        private static string _yodleePassword;

        private static string _smtpServer;
        private static int _smtpPort;
        private static bool _enableSSL;
        private static string _emailAddress;
        private static string _emailPassword;

        private static int _theamID;
        private static int _commandTimeout;
        private static int _retailsEnoughDays;
        private static int _retailsSuggestionDays;

        private static bool _demoMode;
        private static bool _workFlow;
        private static bool _initialised;
        private static bool _showHijri;
        private static bool _budgetalertStop;
        private static bool _branchAccounting;
        private static bool _accountSigmented;
        private static bool _priceValidation;
        private static bool _autoBankCode;
        private static bool _autoVendorCode;
        private static bool _autoCustomerCode;
        private static bool _isSalePrice;
        private static bool _overOrderQuantity;

        private static DateTime _fromDate;
        private static DateTime _toDate;

        private static Dictionary<string,string> _resources;
        private static Dictionary<string, string> _modelResources;
        private static Dictionary<string, string> _commandResources;

        private static List<System.Data.DataRow> _classList;
        private static List<System.Data.DataRow> _branchList;
        private static List<System.Data.DataRow> _projectList;
        private static List<System.Data.DataRow> _divisionList;
        private static List<System.Data.DataRow> _categoryList;
        private static List<System.Data.DataRow> _currencyList;
        private static List<System.Data.DataRow> _indicatorList;
        private static List<System.Data.DataRow> _warehouseList;
        private static List<System.Data.DataRow> _itemGroupList;
        private static List<System.Data.DataRow> _costCenterList;
        private static List<System.Data.DataRow> _paymentMeansList;
        private static List<System.Data.DataRow> _trackingTypeList;
        private static List<System.Data.DataRow> _vendorList;
        private static List<System.Data.DataRow> _customerList;
        private static List<System.Data.DataRow> _partnerList;
        private static List<System.Data.DataRow> _inventoryChartList;
        private static List<System.Data.DataRow> _itemSubCategoryList;
        private static List<System.Data.DataRow> _itemSubClassList;
        private static List<System.Data.DataRow> _itemSubGroupList;
        private static List<System.Data.DataRow> _itemTypeList;
        private static List<System.Data.DataRow> _bankList;

        private static DataSet  _resourceDataset;

        public static string ConnectionString
        {
            get { return Utility._connectionString; }
            set { Utility._connectionString = value; }
        }

        public static string ReportConnectionString
        {
            get { return Utility._reportConnectionString; }
            set { Utility._reportConnectionString = value; }
        }

        public static Dictionary<string, string> ModelResources
        {
            get { return Utility._modelResources; }
            set { Utility._modelResources = value; }
        }

        public static Dictionary<string, string> Resources
        {
            get { return Utility._resources; }
            set { Utility._resources = value; }
        }

        public static Dictionary<string, string> CommandResources
        {
            get { return Utility._commandResources; }
            set { Utility._commandResources = value; }
        }


        public static Dictionary<string, string> MessageDictionary
        {
            get { return Utility._messageDictionary; }
            set { Utility._messageDictionary = value; }
        }

        public static DataSet ResourceDataset
        {
            get { return Utility._resourceDataset; }
            set { Utility._resourceDataset = value; }
        }

        public static string CompanyName
        {
            get { return Utility._companyName; }
            set { Utility._companyName = value; }
        }

        public static string FirstAddress
        {
            get { return Utility._firstAddress; }
            set { Utility._firstAddress = value; }
        }

        public static string SecondAddress
        {
            get { return Utility._secondAddress; }
            set { Utility._secondAddress = value; }
        }

        public static string CityName
        {
            get { return Utility._cityName; }
            set { Utility._cityName = value; }
        }

        public static string CountryName
        {
            get { return Utility._countryName; }
            set { Utility._countryName = value; }
        }

        public static string ZipCode
        {
            get { return Utility._zipCode; }
            set { Utility._zipCode = value; }
        }

        public static string PhoneNumnber
        {
            get { return Utility._phoneNumnber; }
            set { Utility._phoneNumnber = value; }
        }

        public static string SmtpServer
        {
            get { return Utility._smtpServer; }
            set { Utility._smtpServer = value; }
        }

        public static int SmtpPort
        {
            get { return Utility._smtpPort; }
            set { Utility._smtpPort = value; }
        }

        public static bool EnableSSL
        {
            get { return Utility._enableSSL; }
            set { Utility._enableSSL = value; }
        }

        public static string EmailAddress
        {
            get { return Utility._emailAddress; }
            set { Utility._emailAddress = value; }
        }

        public static string EmailPassword
        {
            get { return Utility._emailPassword; }
            set { Utility._emailPassword = value; }
        }

        public static string DateFormat
        {
            get { return Utility._dateFormat; }
            set { Utility._dateFormat = value; }
        }

        public static string CalendarImage
        {
            get { return Utility._calendarImage; }
            set { Utility._calendarImage = value; }
        }

        public static string ReportImage
        {
            get { return Utility._reportImage; }
            set { Utility._reportImage = value; }
        }

        public static string HrmsLink
        {
            get { return Utility._hrmsLink; }
            set { Utility._hrmsLink = value; }
        }

        public static string RedirectPath
        {
            get { return Utility._redirectPath; }
            set { Utility._redirectPath = value; }
        }

        public static string NegativeSign
        {
            get { return Utility._negativeSign; }
            set { Utility._negativeSign = value; }
        }

        public static string CreditCardKey
        {
            get { return Utility._creditCardKey; }
            set { Utility._creditCardKey = value; }
        }

        public static string CreditCardPin
        {
            get { return Utility._creditCardPin; }
            set { Utility._creditCardPin = value; }
        }

        public static string HacKey
        {
            get { return Utility._hacKey; }
            set { Utility._hacKey = value; }
        }

        public static string HacPin
        {
            get { return Utility._hacPin; }
            set { Utility._hacPin = value; }
        }

        public static string YodleeRestURL
        {
            get { return Utility._yodleeRestURL; }
            set { Utility._yodleeRestURL = value; }
        }

        public static string CobrandLogin
        {
            get { return Utility._cobrandLogin; }
            set { Utility._cobrandLogin = value; }
        }

        public static string CobrandPassword
        {
            get { return Utility._cobrandPassword; }
            set { Utility._cobrandPassword = value; }
        }

        public static string YodleeLogin
        {
            get { return Utility._yodleeLogin; }
            set { Utility._yodleeLogin = value; }
        }

        public static string YodleePassword
        {
            get { return Utility._yodleePassword; }
            set { Utility._yodleePassword = value; }
        }

        public static string LogoImage
        {
            get { return Utility._logoImage; }
            set { Utility._logoImage = value; }
        }

        public static int TheamID
        {
            get { return Utility._theamID; }
            set { Utility._theamID = value; }
        }

        public static int CommandTimeout
        {
            get { return Utility._commandTimeout; }
            set { Utility._commandTimeout = value; }
        }

        public static int RetailsEnoughDays
        {
            get { return Utility._retailsEnoughDays; }
            set { Utility._retailsEnoughDays = value; }
        }

        public static int RetailsSuggestionDays
        {
            get { return Utility._retailsSuggestionDays; }
            set { Utility._retailsSuggestionDays = value; }
        }  

        public static bool Initialised
        {
            get { return Utility._initialised; }
            set { Utility._initialised = value; }
        }

        public static bool ShowHijri
        {
            get { return Utility._showHijri; }
            set { Utility._showHijri = value; }
        }

        public static bool BudgetalertStop
        {
            get { return Utility._budgetalertStop; }
            set { Utility._budgetalertStop = value; }
        }

        public static bool DemoMode
        {
            get { return Utility._demoMode; }
            set { Utility._demoMode = value; }
        }

        public static bool WorkFlow
        {
            get { return Utility._workFlow; }
            set { Utility._workFlow = value; }
        }

        public static bool BranchAccounting
        {
            get { return Utility._branchAccounting; }
            set { Utility._branchAccounting = value; }
        }

        public static bool AccountSigmented
        {
            get { return Utility._accountSigmented; }
            set { Utility._accountSigmented = value; }
        }

        public static bool PriceValidation
        {
            get { return Utility._priceValidation; }
            set { Utility._priceValidation = value; }
        }

        public static bool AutoBankCode
        {
            get { return Utility._autoBankCode; }
            set { Utility._autoBankCode = value; }
        }

        public static bool AutoVendorCode
        {
            get { return Utility._autoVendorCode; }
            set { Utility._autoVendorCode = value; }
        }

        public static bool AutoCustomerCode
        {
            get { return Utility._autoCustomerCode; }
            set { Utility._autoCustomerCode = value; }
        }

        public static DateTime FromDate
        {
            get { return Utility._fromDate; }
            set { Utility._fromDate = value; }
        }

        public static DateTime ToDate
        {
            get { return Utility._toDate; }
            set { Utility._toDate = value; }
        }

        public static List<System.Data.DataRow> ClassList
        {
            get { return Utility._classList; }
            set { Utility._classList = value; }
        }

        public static List<System.Data.DataRow> BranchList
        {
            get { return Utility._branchList; }
            set { Utility._branchList = value; }
        }

        public static List<System.Data.DataRow> ProjectList
        {
            get { return Utility._projectList; }
            set { Utility._projectList = value; }
        }

        public static List<System.Data.DataRow> DivisionList
        {
            get { return Utility._divisionList; }
            set { Utility._divisionList = value; }
        }
        
        public static List<System.Data.DataRow> CategoryList
        {
            get { return Utility._categoryList; }
            set { Utility._categoryList = value; }
        }

        public static List<System.Data.DataRow> CurrencyList
        {
            get { return Utility._currencyList; }
            set { Utility._currencyList = value; }
        }

        public static List<System.Data.DataRow> IndicatorList
        {
            get { return Utility._indicatorList; }
            set { Utility._indicatorList = value; }
        }

        public static List<System.Data.DataRow> WarehouseList
        {
            get { return Utility._warehouseList; }
            set { Utility._warehouseList = value; }
        }

        public static List<System.Data.DataRow> ItemGroupList
        {
            get { return Utility._itemGroupList; }
            set { Utility._itemGroupList = value; }
        }

        public static List<System.Data.DataRow> CostCenterList
        {
            get { return Utility._costCenterList; }
            set { Utility._costCenterList = value; }
        }

        public static List<System.Data.DataRow> PaymentMeansList
        {
            get { return Utility._paymentMeansList; }
            set { Utility._paymentMeansList = value; }
        }

        public static List<System.Data.DataRow> TrackingTypeList
        {
            get { return Utility._trackingTypeList; }
            set { Utility._trackingTypeList = value; }
        }

        public static List<System.Data.DataRow> VendorList
        {
            get { return Utility._vendorList; }
            set { Utility._vendorList = value; }
        }

        public static List<System.Data.DataRow> CustomerList
        {
            get { return Utility._customerList; }
            set { Utility._customerList = value; }
        }

        public static List<System.Data.DataRow> PartnerList
        {
            get { return Utility._partnerList; }
            set { Utility._partnerList = value; }
        }

        public static List<System.Data.DataRow> InventoryChartList
        {
            get { return Utility._inventoryChartList; }
            set { Utility._inventoryChartList = value; }
        }

        public static List<System.Data.DataRow> ItemSubCategoryList
        {
            get { return Utility._itemSubCategoryList; }
            set { Utility._itemSubCategoryList = value; }
        }

        public static List<System.Data.DataRow> ItemSubClassList
        {
            get { return Utility._itemSubClassList; }
            set { Utility._itemSubClassList = value; }
        }

        public static List<System.Data.DataRow> ItemSubGroupList
        {
            get { return Utility._itemSubGroupList; }
            set { Utility._itemSubGroupList = value; }
        }

        public static List<System.Data.DataRow> ItemTypeList
        {
            get { return Utility._itemTypeList; }
            set { Utility._itemTypeList = value; }
        }

        public static List<System.Data.DataRow> BankList
        {
            get { return Utility._bankList; }
            set { Utility._bankList = value; }
        }

        public static bool IsSalePrice
        {
            get { return Utility._isSalePrice; }
            set { Utility._isSalePrice = value; }
        }
          
        public static bool OverOrderQuantity
        {
            get { return Utility._overOrderQuantity; }
            set { Utility._overOrderQuantity = value; }
        }
    }
}

