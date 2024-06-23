using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHotel_DDD
{
    public class MenuSelector : IMenuSelector
    {
        public MenuOption SelectOption(string input)
        {
            // Lógica de negocio para seleccionar una opción de menú
            if (input == "1")
            {
                return new MenuOption(1, "Base de Datos en Memoria");
            }
            else if (input == "2")
            {
                return new MenuOption(2, "Base de Datos en MySQL");
            }
            else
            {
                return new MenuOption(-1, "Opción no válida");
            }
        }
    }
}
