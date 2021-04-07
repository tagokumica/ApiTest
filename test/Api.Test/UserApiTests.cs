using System.Net.Http.Json;
using System.Threading.Tasks;
using Api.Test.Collection;
using Api.Test.Config;
using Application.ViewModel;
using Xunit;

namespace Api.Test
{
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public class UserApiTests
    {
        private readonly IntegrationTestsFixture<Startup> _testsFixture;

        public UserApiTests(IntegrationTestsFixture<Startup> testsFixture)
        {
            _testsFixture = testsFixture;
        }


        [Fact(DisplayName = "Validar Senha e Retornar com Sucesso")]
        [Trait("Categoria", "Integração API - Validar Senha")]
        public async Task Password_Validate_SuccessReturn()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "Asdfghj8*"
            };


            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/usuario/validar-senha", user);

            // Assert
            postResponse.EnsureSuccessStatusCode();
        }

        [Fact(DisplayName = "Validar Senha e Retornar com Falha")]
        [Trait("Categoria", "Integração API - Validar Senha")]
        public async Task Password_Validate_FailedReturn()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "Asdfghj"
            };


            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/usuario/validar-senha", user);

            // Assert
            postResponse.EnsureSuccessStatusCode();
        }

    }
}
