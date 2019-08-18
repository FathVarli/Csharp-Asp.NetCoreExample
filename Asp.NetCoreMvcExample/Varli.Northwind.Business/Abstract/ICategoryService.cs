using System;
using System.Collections.Generic;
using System.Text;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
