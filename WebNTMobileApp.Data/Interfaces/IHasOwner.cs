using System;
using System.Collections.Generic;
using System.Text;

namespace WebNTMobileApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwerId { set; get; }
    }
}
