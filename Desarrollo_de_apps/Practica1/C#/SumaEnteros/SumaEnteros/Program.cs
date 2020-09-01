using System;

namespace SumaEnteros
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaración de variables
            int num1, num2, suma;
            string linea;

            //Impresión del titulo de la aplicación
            Console.WriteLine("SUMA DE DOS ENTEROS");

            //Petición del primer número
            Console.WriteLine("Ingresa un numero");
            //Ingreso y asignación del dato a través del teclado
            linea = Console.ReadLine();
            num1 = int.Parse(linea);//Cast del String a Int
            //Se pide el otro número
            Console.WriteLine("Ingresa otro numero");
            num2 = int.Parse(Console.ReadLine());//Cast al mismo tiempo que se lee el dato
            //Se realiza la suma
            suma = num1 + num2;
            //Se imprime el resultado concatenando texto y variable
            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
