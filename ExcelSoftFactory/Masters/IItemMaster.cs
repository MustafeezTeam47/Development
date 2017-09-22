using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Masters
{
    public interface IItemMaster
    {
        int ItemID { get; set; }
        string ItemCode { get; set; }
        string ItemName { get; set; }
        
        int? CategoryID { get; set; }

        bool IsActive { get; set; }
    }
}
