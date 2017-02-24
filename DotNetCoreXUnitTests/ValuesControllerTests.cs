using DotNetCoreWebApp.Controllers;
using System;
using Xunit;

namespace DotNetCoreXUnitTests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Test1()
        {
            ValuesController controller = new ValuesController();

            var response = controller.Get();

            Assert.NotNull(response);

            foreach (var item in response)
            {
                Assert.True(!string.IsNullOrWhiteSpace(item));
            }
            
        }

    }
}
