using System;
using System.Collections.Generic;
using System.Text;
using Varli.Core.DataAccess;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}
