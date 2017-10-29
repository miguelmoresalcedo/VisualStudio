using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {

        public static int menu()
        {
            int numero = 0;
            Console.WriteLine("Menu: " + "\n");
            Console.WriteLine("1-> Un parametro de tipo real y devuelve el numero tras truncar la parte decimal a 0 deciales" + "\n");
            Console.WriteLine("2-> Un parametro de tipo real y otro parametro de tipo entero. Almacena sobre el segundo el numero tras truncar la parte decimal a 0" + "\n");
            Console.WriteLine("3-> Un parametro de tipo real. El metodo almacena sobre sobre el primero el numero tras truncar la parte decimal a 0" + "\n");
            Console.WriteLine("4-> Un parametro de tipo real y otro de tipo entero y devuelve el numero tras truncar la parte decimal a los decimales indicados por el segundo numero" + "\n");
            Console.WriteLine("5-> Un parametro de tipo real, otro entero y otro real. Almacena sobre el tercer parametro el numero tras truncar a los decimales indicados por el segundo numero" + "\n");
            Console.WriteLine("6º Un parametro de tipo real y otro entero. Almacena sobre el primer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro." + "\n");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;


        }


        public static double method1(ref double number1) //creamos un valor double y simplemete con Math.Truncate lo truncamos y nos quitamos los decimales 
        {
            return number1 = Math.Truncate(number1);
        }

        public static void method2(double number1, ref int num) //creamos un double y un entero por referencia, truncamos el double quitandole los decimales y lo guardamos en el entero que hemos creado
        {


            number1 = Math.Truncate(number1);
            num += Convert.ToInt32(number1);
        }

        public static void method3(ref double number1) //creo una variable double, y guardo sobre esta su valor pero truncado a 0 decimales
        {
            number1 += Math.Truncate(number1);
        }



        static void Main(string[] args)
        {
            int option;
            double value = 235.347;
            int num = 0;//como vamos a usarlo para guardar otro numero debemos ponerlo a 0
            

            do
            {
                option = menu();
                switch (option)
                {
                    case 1:
                        method1(ref value);
                        Console.WriteLine(value + "\n");
                        break;

                    case 2:
                        method2(value, ref num);
                        Console.WriteLine(num + "\n");
                        break;

                    case 3:
                        method3(ref value);
                        Console.WriteLine(value + "\n");
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        
                        break;

                    case 6:
                        
                        break;


                }

            } while (option != 9);

        
    }
    }
}
