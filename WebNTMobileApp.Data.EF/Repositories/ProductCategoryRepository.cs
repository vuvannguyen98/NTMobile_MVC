using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebNTMobileApp.Data.Entities;
using WebNTMobileApp.Data.IRpositories;

namespace WebNTMobileApp.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {

        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
        }

      
    }
}
