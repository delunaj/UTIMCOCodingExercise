using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text;
using UTIMCOCodingExercise;
using System.Net.Http;
using Xunit;
using System.Threading.Tasks;
using UTIMCOCodingExercise.Controllers;
using UTIMCOCodingExercise.Services;
using Microsoft.AspNetCore.TestHost;

namespace UTIMCOCodingExercise.Test
{
    public class BasicTests : IClassFixture<WebApplicationFactory<UTIMCOCodingExercise.Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BasicTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        //Test data access
        [Fact]
        public async Task ReturnJsonData()
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync("/DataSet");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            //Assert
            Assert.NotNull(responseString);
        }
    }

}
