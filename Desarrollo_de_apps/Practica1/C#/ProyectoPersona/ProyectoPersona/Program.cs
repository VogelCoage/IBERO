using System;

namespace ProyectoPersona
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Tipos de datos y su correspondiente clase (ambos son válidos)
            string nombre; //Clase String
            int edad; //Clase Int64
            double estatura; //Clase Double
            bool status; //Clase Boolean

            Console.Write("Ingresa tu nombre: ");
            //Se lee una cadena
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu edad: ");
            //Se lee la cadena y con Parse se pasa a entero
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresa tu estatura: ");
            //Se lee la cadena y con Parse se pasa a double
            estatura = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu status: ");
            //Se lee la cadena y con Parse se pasa a booleano
            status = bool.Parse(Console.ReadLine());

            /*Los datos se pasan a formato de cadena con ToString explícito
            * (pudiera omitirse y se aplica de manera implícita
            */           
            Console.WriteLine(nombre + " " + edad.ToString() + " " +
             estatura.ToString() + " " + status.ToString());

            Console.ReadKey();
        }
    }
}
