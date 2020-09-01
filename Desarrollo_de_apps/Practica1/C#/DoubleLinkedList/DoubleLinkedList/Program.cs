using System;

namespace DoubleLinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Se instancia el objeto de tipo DoubleList
            DoubleList myList = new DoubleList();

            //Se insertan nodos de manera ordenada
            myList.InsertOrdered("Ana");
            myList.InsertOrdered("Pedro");
            myList.InsertOrdered("María");
            myList.InsertOrdered("Ernesto");
            myList.InsertOrdered("Orlando");
            myList.InsertOrdered("Cecilia");

            //Se imprime el contenido de la lista
            Console.WriteLine("Se imprime la lista en orden...");
            myList.Print();
            Console.WriteLine();

            //Se imprime la lista de manera inversa
            Console.WriteLine("Se imprime la lista en orden inverso...");
            myList.PrintReverse();
            Console.WriteLine();

            //Se eliminan 3 nodos de la lista
            myList.Delete("María");
            myList.Delete("Pedro");
            myList.Delete("Ana");

            //Se imprime el contenido de la lista
            Console.WriteLine("Se imprime la lista en orden...");
            myList.Print();
            Console.WriteLine();

            //Se imprime la lista de manera inversa
            Console.WriteLine("Se imprime la lista en orden inverso...");
            myList.PrintReverse();
            Console.WriteLine();
        }
    }
}
