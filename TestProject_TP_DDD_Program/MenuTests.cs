using Xunit;
using Moq;
using System;
using System.IO;
using System.Text;
using MenuHotel_DDD;

namespace MenuApp.Tests
{
    public class MenuTests
    {
        [Fact]
        public void ShowMenu_WritesMenuOptionsToConsole()
        {
            // Preparar
            var menuSelector = new Mock<IMenuSelector>();
            var menu = new Menu(menuSelector.Object);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Actuar
            menu.ShowMenu();

            // Afirmar
            var output = stringWriter.ToString();
            Assert.Contains("Seleccione una opción:", output);
            Assert.Contains("1. Base de Datos en Memoria", output);
            Assert.Contains("2. Base de Datos en MySQL", output);
            Assert.Contains("3. Base de Datos en MongoDB", output);
            Assert.Contains("4. Ir a Menu Clientes", output);
            Assert.Contains("5. Ir a Menu Reservas", output);
            Assert.Contains("6. Salir", output);
        }

      

       

        [Fact]
        public void ProcessEmptyInput()
        {
            // Preparar
            var menuSelector = new Mock<IMenuSelector>();
            var menu = new Menu(menuSelector.Object);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            menuSelector.Setup(ms => ms.SelectOption(It.IsAny<string>()))
                .Returns((string input) => input == "1" ? new MenuOption(1, "Base de Datos en Memoria") : new MenuOption(-1, "Opción no válida"));

            // Actuar
            menu.ProcessSelection("");

            // Afirmar
            var output = stringWriter.ToString();
            Assert.Contains("Seleccionó la opción 1: Base de Datos en Memoria", output);
        }

    }
}
