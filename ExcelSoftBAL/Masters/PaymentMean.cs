using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelSoftFactory.Masters;
using System.Data;

namespace ExcelSoftBAL.Masters
{
    public class PaymentMean:IPaymentMean
    {
        private int _paymentMeanID;
        private string _paymentMeanCode;
        private string _paymentMeanName;
        private bool _isActive;

        public int PaymentMeanID
        {
            get
            {
                return _paymentMeanID;
            }

            set
            {
                _paymentMeanID = value;
            }
        }

        public string PaymentMeanCode
        {
            get
            {
                return _paymentMeanCode;
            }

            set
            {
                _paymentMeanCode = value;
            }
        }

        public string PaymentMeanName
        {
            get
            {
                return _paymentMeanName;
            }

            set
            {
                _paymentMeanName = value;
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

        public string SavePaymentMean()
        {
            try
            {
                return new ExcelSoftDAL.Masters.PaymentMean().SavePaymentMean(this);
            }
            catch { throw; }
        }
        public DataSet ShowPaymentMeans()
        {
            try
            {
                return new ExcelSoftDAL.Masters.PaymentMean().ShowPaymentMeans();
            }
            catch
            { throw; }
        }
        public DataSet GetPaymentMean()
        {
            try
            {
                return new ExcelSoftDAL.Masters.PaymentMean().GetPaymentMean(this);
            }
            catch
            { throw; }
        }
    }
}
