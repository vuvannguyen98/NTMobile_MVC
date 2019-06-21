﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebNTMobileApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeyWords { set; get; }
        string SeoDescription { set; get; }
    }
}
