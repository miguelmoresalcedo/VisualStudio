using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Metodos

namespace ConsoleApplication1
{
    class Program
    {
        static public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        //ref vale para guardar un valor antes de que acabe la funcion 
        //out es parecido al ref pero tiene la condicion de que siempre tiene que cambiar le valor.
        static void Main(string[] args)
        {
            int numero1, numero2, resultado; //mirar la otra forma de hacerlo en github, siempre hay que poner todas las variables a 0

            Console.WriteLine("Introduce numero 1: ");
            numero1 = Int32.Parse(Console.ReadLine()); //sirve para convertir una cadena en un int, lo que hay dentro de los parentesis

            Console.WriteLine("Introduce numero 2: ");
            numero2 = Int32.Parse(Console.ReadLine());

            //1. Llamada tradicional
            resultado = Sumar(numero1, numero2);
            Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey(); //para que no se cierre la ventana y te de tiempo a ver la consola

        }
    }
}
