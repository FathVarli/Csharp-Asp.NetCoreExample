using System;
using System.Collections.Generic;
using System.Text;
using Varli.Core.Entities;

namespace Varli.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
