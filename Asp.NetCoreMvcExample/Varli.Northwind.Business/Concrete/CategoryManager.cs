using System;
using System.Collections.Generic;
using System.Text;
using Varli.Northwind.Business.Abstract;
using Varli.Northwind.DataAccess.Abstract;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
