using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Masters
{
    public interface ICompany
    {
        int CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Address { get; set; }
        long? Mobile { get; set; }

        long? PhoneNo { get; set; }
    }
}
