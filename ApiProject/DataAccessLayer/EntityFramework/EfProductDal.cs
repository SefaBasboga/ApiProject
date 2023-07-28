using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.GenericRepositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {

        }

        public List<Product> GetProductsWithCategories()
        {
            using var context = new Context();
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}
