using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Masters
{
    public interface IPaymentMean
    {
        int PaymentMeanID { get; set; }
        string PaymentMeanCode { get; set; }
        string PaymentMeanName { get; set; }

        bool IsActive { get; set; }
    }
}
