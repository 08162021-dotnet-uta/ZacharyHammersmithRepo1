using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{

    public class StoreRepositoryTests 
    {
        public void Test_StoreCollection(){

            var sut = new StoreRepository();

            var actual = sut.Stores;

            Assert.NotNull(actual);

        }

        public void Test_CustomerCollection(){

            var sut = new CustomerRepository();

            var actual = sut.Customers;

            Assert.NotNull(actual);

        }

        public void Test_ProductCollection(){

            var sut = new ProductRepository();

            var actual = sut.Products;

            Assert.NotNull(actual);

        }

        public void Test_OrderCollection(){

            var sut = new OrderRepository();

            var actual = sut.Orders;

            Assert.NotNull(actual);

        }
    }
}