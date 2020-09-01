using System;
using System.Collections.Generic;

namespace proyectoAuto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Se instancia un objeto de tipo auto
            Auto miVocho = new Auto("VW", "Sedan", "Azul", 2);

            //Se imprimen sus características y el nuevo método
            Console.WriteLine(miVocho.ToString());
            Console.WriteLine(miVocho.Pitar());
            Console.WriteLine();
            //Ahora se instancia un objeto de tipo Camion
            Camion miCamion = new Camion("Dina", "Super camión", "Verde", 2, 40);
            //De igual manera se imprimen sus características y el método Pitar
            Console.WriteLine(miCamion.ToString());
            Console.WriteLine(miCamion.Pitar());

            Console.ReadKey();
        }

        public void EjemploAutos()
        {
            //Se declara una lista
            List<Auto> miLista = new List<Auto>();

            //Se instancian 3 objetos de tipo Auto
            Auto miVocho = new Auto("VW", "Sedan", "Blanco", 2);
            Auto miFerrari;
            Auto miCarro = null;

            //Se inicializa la instancia miFerrari
            miFerrari = new Auto();
            miFerrari.marca = "Ferrari";
            miFerrari.modelo = "Maranello";
            miFerrari.color = "Rojo";

            //Se imprimen las instancias
            Console.WriteLine(miVocho);
            Console.WriteLine(miFerrari);
            //Esta no se imprimirá porque no se ha inicializado (está vacía)
            Console.WriteLine(miCarro);

            //Se mueven estas dos instancias
            miVocho.avanza(50);
            miFerrari.avanza(100);

            //Se imprimen de nuevo para observar los cambios
            Console.WriteLine(miVocho);
            Console.WriteLine(miFerrari);

            //La instancia miCarro ahora apunta a la instancia miBocho (se igualan)
            miCarro = miVocho;

            //Se observan los cambios
            Console.WriteLine(miCarro);

            //Se avanza esta instancia
            miCarro.avanza(100);

            //Se imprimen ambas instancias para comprobar que siguen igualados
            Console.WriteLine(miCarro);
            Console.WriteLine(miVocho);

            //Ahora la instancia miCarro apunta a la instancia miFerrari
            miCarro = miFerrari;

            //Se imprime la instancia miCarro, se modifica su posición y se vuelve a imprimir
            Console.WriteLine(miCarro);
            miCarro.avanza(200);
            Console.WriteLine(miCarro);

            //Se imprime el número de elementos incluidos en miLista (no hay)
            Console.WriteLine("No. elementos " + miLista.Count);

            //Se agregan tres elementos a miLista
            miLista.Add(miVocho);
            miLista.Add(miFerrari);
            miLista.Add(new Auto("Nissan", "Tsuru", "Gris", 4));

            Console.WriteLine("No. elementos " + miLista.Count + " Los elementos son: ");

            //Ciclo para imprimir cada elemento dentro de la lista miLista
            foreach (var coche in miLista)
            {
                Console.WriteLine("\t" + coche);
            }
        }
    }
}
