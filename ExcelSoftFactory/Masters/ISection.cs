using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelSoftFactory.Masters
{
   public interface ISection
    {
        int SectionID { get; set; }
        string SectionCode { get; set; }
        string SectionName { get; set; }
        bool IsActive { get;set;}
    }
}
