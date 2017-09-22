using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Masters
{
    public interface ICustomer
    {
        int CustomerID { get; set; }
        string CustomerCode { get; set; }
        string CustomerName { get; set; }

        string Address { get; set; }

        string Town { get; set; }

        string TransportName { get; set; }

        long? Mobile1 { get; set; }

        long? Mobile2 { get; set; }

        long? PhoneNo { get; set; }

        long? GstNumber { get; set; }
    }
}
