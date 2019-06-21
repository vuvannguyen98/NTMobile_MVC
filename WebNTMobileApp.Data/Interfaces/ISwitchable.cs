using System;
using System.Collections.Generic;
using System.Text;
using WebNTMobileApp.Data.Enums;

namespace WebNTMobileApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
