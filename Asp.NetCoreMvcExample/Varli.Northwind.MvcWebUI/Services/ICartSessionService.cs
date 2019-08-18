using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varli.Northwind.Entities.Concrete;

namespace Varli.Northwind.MvcWebUI.Services
{
   public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
