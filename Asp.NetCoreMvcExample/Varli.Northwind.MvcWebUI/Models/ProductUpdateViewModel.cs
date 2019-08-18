using System.Collections.Generic;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}