using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {

        public static int menu()
        {
            int numero = 0; //creamos menu y una variable para los numeros que la dejamos a 0
            Console.WriteLine("Menu: " + "\n");
            Console.WriteLine("1-> Un parametro de tipo real y devuelve el numero tras truncar la parte decimal a 0 deciales" + "\n");
            Console.WriteLine("2-> Un parametro de tipo real y otro parametro de tipo entero. Almacena sobre el segundo el numero tras truncar la parte decimal a 0" + "\n");
            Console.WriteLine("3-> Un parametro de tipo real. El metodo almacena sobre sobre el primero el numero tras truncar la parte decimal a 0" + "\n");
            Console.WriteLine("4-> Un parametro de tipo real y otro de tipo entero y devuelve el numero tras truncar la parte decimal a los decimales indicados por el segundo numero" + "\n");
            Console.WriteLine("5-> Un parametro de tipo real, otro entero y otro real. Almacena sobre el tercer parametro el numero tras truncar a los decimales indicados por el segundo numero" + "\n");
            Console.WriteLine("6º Un parametro de tipo real y otro entero. Almacena sobre el primer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro." + "\n");
            numero = Convert.ToInt32(Console.ReadLine()); //convertimos texto en numero y lo pasamos por consola
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

        public static void method5(double number1, int number2, ref double save) //tenemos nuestro un valor 1 al cual debemos quitar los decimales que nos diga el valor 2 y el resultado guardarlo en el valor 3, en este caso save.
        {
            save += Math.Round(number1, number2);

        }




        static void Main(string[] args)
        {
            int option; //creamos esta variable para luego igualarlo a menu() y asi poder conseguir que nos coja los numeros de cada caso
            double value = 235.347; //valor
            int num = 0;//como vamos a usarlo para guardar otro numero debemos ponerlo a 0
            double save = 0; //creamos un double para poder almacenar el valor que queremos, y debemos de ponerlo a 0

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
                        method5(value, num, ref save); //tengo en el numero1 el valor inicial, en el valor 2 los decimales que quiero que quite y en el 3 la variable en la que quiero que lo guarde
                        Console.WriteLine(save + "\n");
                        
                        break;

                    case 6:

                        break;


                }

            } while (option != 8);


        }
    }
}
