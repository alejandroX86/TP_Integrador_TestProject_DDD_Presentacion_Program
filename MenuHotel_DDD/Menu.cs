using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHotel_DDD
{
    public class Menu
    {
        private readonly IMenuSelector _menuSelector;

        public Menu(IMenuSelector menuSelector)
        {
            _menuSelector = menuSelector;
        }

        public void ShowMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Base de Datos en Memoria");
            Console.WriteLine("2. Base de Datos en MySQL");
            Console.WriteLine("3. Base de Datos en MongoDB");
            Console.WriteLine("4. Ir a Menu Clientes");
            Console.WriteLine("5. Ir a Menu Reservas");
            Console.WriteLine("6. Salir");
        }


        public void ProcessSelection(string input)
        {
            var menuOption = _menuSelector.SelectOption(input);
            if (menuOption == null || menuOption.Option == -1 || string.IsNullOrWhiteSpace(input))
            {
                // Si la opción no es válida o no se ingresó ninguna opción, se selecciona la opción por defecto (1)
                menuOption = _menuSelector.SelectOption("1");
            }
            Console.WriteLine($"Seleccionó la opción {menuOption.Option}: {menuOption.Description}");
        }
    }
}

