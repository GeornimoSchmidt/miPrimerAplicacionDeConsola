using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraAplicacion
{
    class Program
    {

        static void Main(string[] args)
        {
            string nombre = "Geronimo Schmidt";
            int edad = 21;

            //operaciones aritmeticas

            /*int suma = 5 + 2;
            int resta = 5 - 2;
            double division = 5.00 / 2.00;
            int multiplicacion = 5 * 2;
            int resto = 5 % 2;
            int operacion = 5 * 2 + 8;
            int operacion2 = 5 * (2 + 8);

            //mostrar resultados por consola

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Multiplicacion: " + multiplicacion);
            Console.WriteLine("Resto: " + resto);
            Console.WriteLine("Operacion: " + operacion);
            Console.WriteLine("Operacion2: " + operacion2);

            Console.WriteLine("Hola {0}, tu edad es {1}",nombre,edad);
            Console.ReadKey();
            */
            //pedir datos al usuario

            Console.WriteLine("Ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ok, tu nombre es " + nombre);

            Console.WriteLine("Ingrese su edad ");
            string cadenaDeEntrada = "";
            cadenaDeEntrada = Console.ReadLine();

            try
            {
                edad = Convert.ToInt32(cadenaDeEntrada);
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
            
            
            edad = edad - 1;
            Console.WriteLine("Ok, tu edad es " + cadenaDeEntrada);

            Console.ReadKey();

            



        }
    }
}
