using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHotel_DDD
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trabajo Practico de Laboratorio de Software");
            Console.WriteLine("Proyecto Hotel: Pruaba Unitaria Capa Presentacion MenuSlector");
            Console.WriteLine();
            Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
            Console.WriteLine("Alumnos: Julia Avalos");
            Console.WriteLine("         Leonardo Caceres");
            Console.WriteLine("         Eduardo Arizza");
            Console.WriteLine("         Gonzalo Arizza");
            Console.WriteLine("         Omar Bazar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();





            var menuSelector = new MenuSelector();
            var menu = new Menu(menuSelector);
            menu.ShowMenu();
            Console.Write("Ingrese una opción: ");
            string input = Console.ReadLine() ?? string.Empty;
            menu.ProcessSelection(input);
            Console.ReadLine();
        }
    }
}