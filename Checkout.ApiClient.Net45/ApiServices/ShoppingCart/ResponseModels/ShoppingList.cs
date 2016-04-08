using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.ShoppingCart.RequestModels;

namespace Checkout.ApiServices.ShoppingCart.ResponseModels
{
    public class ShoppingList
    {
        //public int Count {
        //    get { return Data != null ? Data.Count() : 0; }
        //}
        public List<ShoppingItem> Data { get; set; }
    }
}
