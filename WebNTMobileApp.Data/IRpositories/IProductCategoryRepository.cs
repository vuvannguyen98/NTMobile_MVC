using System;
using System.Collections.Generic;
using System.Text;
using WebNTMobileApp.Data.Entities;
using WebNTMobileApp.Infrastructure.Interfaces;

namespace WebNTMobileApp.Data.IRpositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory,int>
    {
    }
}
