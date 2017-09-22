using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Transactions
{
   public interface IBill
    {
        int RetailID { get; set; }
        string RetailNumber { get; set; }
        DateTime RetailDate { get; set; }

        string CustomerName { get; set; }

        string HeaderCaption { get; set; }

        bool TemporaryName { get; set; }

        bool PrintCompanyName { get; set; }

        string NodeNo { get; set; }

        string TransportName { get; set; }

        string PhoneNo { get; set; }

        decimal? DiscountAmount { get; set; }

        decimal? Tax1Amount { get; set; }

        decimal? Tax2Amount { get; set; }

        decimal? OldBalance { get; set; }

        decimal? NetTotal { get; set; }

        int PayByID { get; set; }

        string ItemXML { get; set; }
    }
}
