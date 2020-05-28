using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";

            string[] producto = new string[5];

            string[] cantidad = new string[5];

            string[] precio = new string[5];

           

            for (int i = 0; i < 5; i++)

            {

                Console.Write("Ingrese nombre del producto: ");

                producto [i] = Console.ReadLine();

                Console.Write("Ingrese la cantidad: ");

                cantidad [i] = Console.ReadLine();

                Console.Write("Ingrese precio: ");

                precio[i] = Console.ReadLine();

                line = Console.ReadLine();

                

            }

            for (int x = 0; x < 5; x++)

            {

                Console.WriteLine("producto: " + producto[x] + "cantidad: " + cantidad[x] + "precio: " + precio[x] );

            }

            Console.Write("ingrese el nombre del producto a buscar: ");

            line = Console.ReadLine();

            string consulta = "producto no encontrado";

            for (int i = 0; i < 5; i++)

            {

                if (producto[i] == line)

                {

                    consulta = "producto: " + producto[i] + "cantidad: " + cantidad[i] + "precio: " + precio[i];

                    producto[i] = " ";

                    cantidad[i] = " ";

                    precio[i] = " ";

                    

                }

            }

            Console.Write("ingrese producto a eliminar: ");

            line = Console.ReadLine();

            for (int x = 0; x < 5; x++)

            {

                if (producto[x] == line)

                {

                    producto[x] = "";

                }

            }

            Console.WriteLine(consulta);

            Console.ReadKey();
        }
    }
}
