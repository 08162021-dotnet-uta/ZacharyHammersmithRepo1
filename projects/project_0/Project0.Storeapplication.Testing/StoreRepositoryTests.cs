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
    

    }
}