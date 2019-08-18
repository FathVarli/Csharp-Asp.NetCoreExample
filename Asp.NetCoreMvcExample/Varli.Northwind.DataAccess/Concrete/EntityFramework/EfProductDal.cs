using System;
using System.Collections.Generic;
using System.Text;
using Varli.Core.DataAccess.EntityFramework;
using Varli.Northwind.DataAccess.Abstract;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
