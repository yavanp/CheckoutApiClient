using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.ShoppingCart.RequestModels;
using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    [TestFixture]
    public class ShoppingCartServiceTests : BaseServiceTests
    {
        [Test]
        public void PostShoppingItem()
        {
            var item = new ShoppingItem {Name = "Pepsi", Quantity = 1};
            var response = CheckoutClient.ShoppingCartServive.CreateShoppingItem(item);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void PostShoppingItem2()
        {
            var item = new ShoppingItem { Name = "Coke", Quantity = 3 };
            var response = CheckoutClient.ShoppingCartServive.CreateShoppingItem(item);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void PutShoppingItem()
        {
            var item = new ShoppingItem { Name = "Pepsi", Quantity = 5 };
            var response = CheckoutClient.ShoppingCartServive.UpdateShoppingItem(item);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void GetShoppingItem()
        {
            var item = new ShoppingItem { Name = "Pepsi" };
            var response = CheckoutClient.ShoppingCartServive.GetShoppingItem(item.Name);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void GetShoppingList()
        {
            var response = CheckoutClient.ShoppingCartServive.GetShoppingList();

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void DeleteShoppingItem()
        {
            // add a Pepsi to the shopping cart to make sure we have something to delete
            PostShoppingItem();

            var item = new ShoppingItem { Name = "Pepsi" };
            var response = CheckoutClient.ShoppingCartServive.DeleteShoppingItem(item);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
