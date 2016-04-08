using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.Customers.RequestModels;
using Checkout.ApiServices.Customers.ResponseModels;
using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.ShoppingCart.RequestModels;
using Checkout.ApiServices.ShoppingCart.ResponseModels;
using Checkout.Utilities;

namespace Checkout
{
    public class ShoppingCartService
    {
        public HttpResponse<OkResponse> CreateShoppingItem(ShoppingItem requestModel)
        {
            return new ApiHttpClient().PostRequest<OkResponse>(ApiUrls.ShoppingCart, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<OkResponse> UpdateShoppingItem(ShoppingItem requestModel)
        {
            return new ApiHttpClient().PutRequest<OkResponse>(ApiUrls.ShoppingCart, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<OkResponse> DeleteShoppingItem(ShoppingItem requestModel)
        {
            return new ApiHttpClient().DeleteRequest<OkResponse>(ApiUrls.ShoppingCart, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<ShoppingList> GetShoppingItem(string itemName)
        {
            var getCustomerUri = string.Format(@"{0}/{1}",ApiUrls.ShoppingCart, itemName);
            return new ApiHttpClient().GetRequest<ShoppingList>(getCustomerUri, AppSettings.SecretKey);
        }

        public HttpResponse<CustomerList> GetShoppingList()
        {
            return new ApiHttpClient().GetRequest<CustomerList>(ApiUrls.ShoppingCart, AppSettings.SecretKey);
        }
    }
}
