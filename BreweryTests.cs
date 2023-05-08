using apiTestProject.Brewery;
using System.Threading.Tasks;
using Xunit;

namespace apiTestProject.BreweryTests
{
    public class BreweryTests
    {
        [Fact]
        public async Task Get_Brewery_Info()
        {
            // Arrange
            var breweryAPI = new BreweryAPI();
            string brewery = "b54b16e1-ac3b-4bff-a11f-f7ae9ddc27e0";

            // Act
            var response = await breweryAPI.Get_Brewery(brewery);

            // Assert
            // Assert
            Assert.NotNull(response);
            Assert.Equal("b54b16e1-ac3b-4bff-a11f-f7ae9ddc27e0", response.id);
            Assert.Equal("MadTree Brewing 2.0", response.name);
            Assert.Equal("regional", response.brewery_type);
            Assert.Equal("5164 Kennedy Ave", response.address_1);
            Assert.Null(response.address_2);
            Assert.Null(response.address_3);
            Assert.Equal("Cincinnati", response.city);
            Assert.Equal("Ohio", response.state_province);
            Assert.Equal("45213", response.postal_code);
            Assert.Equal("United States", response.country);
            Assert.Equal("-84.4137736", response.longitude);
            Assert.Equal("39.1885752", response.latitude);
            Assert.Equal("5138368733", response.phone);
            Assert.Equal("http://www.madtreebrewing.com", response.website_url);
            Assert.Equal("Ohio", response.state);
            Assert.Equal("5164 Kennedy Ave", response.street);

        }
    }
}
