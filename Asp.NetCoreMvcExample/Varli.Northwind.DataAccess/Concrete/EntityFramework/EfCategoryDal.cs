using System;
using System.Collections.Generic;
using System.Text;
using Varli.Core.DataAccess.EntityFramework;
using Varli.Northwind.DataAccess.Abstract;
using Varli.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Varli.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>,ICategoryDal
    {

    }
}
