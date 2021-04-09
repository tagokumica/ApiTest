using System.Collections.Generic;
using Application.Interface;
using Application.Validate;
using Application.Validate.Spec;
using Application.ViewModel;
using Xunit;

namespace Application.Test.User
{
    public class PasswordTests
    {
        private UserValidate _userValidate;
        public PasswordTests()
        {
            _userValidate = new UserValidate(new List<ISpec>
            {
                new HasCharNotNullSpec(),
                new HasLowerCharSpec(),
                new HasMinMaxCharsSpec(),
                new HasNumberSpec(),
                new HasSymbolsSpec(),
                new HasUpperCharSpec(),
                new RepeatedCharacterSpec()
            });
        }

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
            var hasMinMax = new HasMinMaxCharsSpec();

            var result = hasMinMax.IsValid(user.Password);

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
            var hasMinMax = new HasMinMaxCharsSpec();

            var result = hasMinMax.IsValid(user.Password);

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
            var hasCharNotNull = new HasCharNotNullSpec();

            var result = hasCharNotNull.IsValid(user.Password);

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

            var result = _userValidate.IsValid(user.Password);

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
            var repeatedCharacter = new RepeatedCharacterSpec();

            var result = repeatedCharacter.IsValid(user.Password);

            // Assert
            Assert.False(result);
        }


    }
}
