using System;

namespace SimpleLinkedList
{
    class MainClass
    {
        //Método principal del programa
        public static void Main(string[] args)
        {
            //Instancia del objeto de tipo SimpleList
            SimpleList myList = new SimpleList();

            //Se impprime el contenido de la lista (está vacía)
            myList.Print();
            Console.WriteLine();

            //Se insertan nodos en la lista de manera ordenada
            myList.InsertOrdered("Daniela");
            myList.InsertOrdered("Andrew");
            myList.InsertOrdered("Nicolas");
            myList.InsertOrdered("Emiliano");
            myList.InsertOrdered("Ricardo");
            myList.InsertOrdered("Ale");
            myList.InsertOrdered("Karlita");
            myList.InsertOrdered("Regina");
            myList.InsertOrdered("Andrea");
            myList.InsertOrdered("Oliver");
            myList.InsertOrdered("Bety");
            myList.InsertOrdered("Alex");

            //Se imprime el contenido de la lista
            myList.Print();
            Console.WriteLine();

            //Se borran cuatro elementos
            myList.Delete("Ale");
            myList.Delete("Ricardo");
            myList.Delete("Karlita");
            myList.Delete("Omar");

            //Se vuelve a imprimir la lista entera
            myList.Print();
            Console.WriteLine();

        }
    }
}
