using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menuu
{
    internal class Menuu
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Menu de mis datos");
                Console.WriteLine("\n" +
                    "\n 1.- Nombre" +
                    "\n 2.- Edad" +
                    "\n 3.- Pasatiempo"+
                    "\n 4.- comida favorita"+
                    "\n 5.- Bebida favorita"+
                    "\n 6.- Color favorito"+

                    "\n 7.- salir \n"
                    );
                Console.WriteLine("Elija una opcion :   ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch ( opcion )
                {
                    case 1:
                        Console.WriteLine("Mi nombre es Fabian");
                        break;
                        case 2:
                        Console.WriteLine("Tengo la edad de 24 años");
                        break;
                        case 3:
                        Console.WriteLine("Jugar videojuegos, escuchar musica, jugar fut");
                        break;
                        case 4:
                        Console.WriteLine("Un buen pozole");
                        break;
                        case 5:
                        Console.WriteLine("La limonda con chia y un vaso de cocacola bien fria");
                        break;
                    case 6:
                        Console.WriteLine("Mi color favorito es el morado y el negro");
                        break;  
                        case 7:
                        Console.WriteLine("Saliendo...");
                        break;

                        default: Console.WriteLine("Elija una que si este");
                        break;  
                }
                Console.ReadKey();

            } while (opcion != 7);

        }

    }
}
