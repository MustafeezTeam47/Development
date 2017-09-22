using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSoftFactory.Administrator
{
  public  interface IUser
    {
        int UserID { get; set; }
        string UserCode { get; set; }

        string UserName { get; set; }
        string Password { get; set; }
        int? RoleID { get; set; }
        bool IsActive { get; set; }

        long? MobileNo { get; set; }

        long? PhoneNo { get; set; }

    }
}
