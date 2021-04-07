using System.Text.RegularExpressions;
using Application.Validate;
using Application.ViewModel;
using Xunit;

namespace Application.Test.User
{
    public class PasswordTests
    {


        [Fact(DisplayName = "Validar Senha com Nove ou mais caracteres")]
        [Trait("Categoria", "Senha")]
        public void Password_Validate_NineOrMoreCharacters()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "Asdfghjklzxcvb1+"
            };

            // Act
            var validationResult = new UserValidate();

            var result = validationResult.IsValid(user.Password);

            // Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Validar Senha com menos caracteres")]
        [Trait("Categoria", "Senha")]
        public void Password_Validate_inValidNineOrMoreCharacters()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "A1+"
            };

            // Act
            var validationResult = new UserValidate();

            var result = validationResult.IsValid(user.Password);

            // Assert
            Assert.False(result);
        }

        [Fact(DisplayName = "Validar Senha vazia")]
        [Trait("Categoria", "Senha")]
        public void Password_Validate_EmptyCharacters()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = ""
            };

            // Act
            var validationResult = new UserValidate();

            var result = validationResult.IsValid(user.Password);

            // Assert
            Assert.False(result);
        }
        [Fact(DisplayName = "Validar Senha Válida")]
        [Trait("Categoria", "Senha")]
        public void Password_Validate_PasswordValid()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "Asdfghjkl9*"
            };

            // Act
            var validationResult = new UserValidate();

            var result = validationResult.IsValid(user.Password);

            // Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Validar Senha Caracter Repetido")]
        [Trait("Categoria", "Senha")]
        public void Password_Validate_PasswordCharacterRepeat()
        {
            // Arrange
            var user = new UserViewModel()
            {
                Password = "Aassdfghjkl9*"
            };

            // Act
            var validationResult = new UserValidate();

            var result = validationResult.IsValid(user.Password);

            // Assert
            Assert.False(result);
        }


    }
}
