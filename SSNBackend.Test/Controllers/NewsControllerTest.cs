using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Models;
using SSNBackend.Controllers;
using SSNBackend.Test.FakeRepositories;
using Xunit;

namespace SSNBackend.Test.Controllers
{
    public class NewsControllerTest
    {
        [Fact]
        public void TestAllNews()
        {
            var repository = new NewsRepositoryFake();
            var newsController = new NewsController(repository);

            var allnewses = newsController.Index().Model as IEnumerable<News>;
            
            Assert.Equal(4, allnewses.Count());
        }
    }
}