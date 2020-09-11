using System;
namespace ProyectoBarco
{
    //Clase principal que implementa la interface Navegación
    public class Barco : INavegacion
    {
        //Atributos de la clase
        public String nombre;
        public int noVelas;
        public bool ancla;

        //Constructor primario (sin argumentos)
        public Barco()
        {
            nombre = "Sin nombre";
            noVelas = 2;
        }

        //Constructor sobrecargado (con 2 argumentos)
        public Barco(String nombre, int noVelas)
        {
            this.nombre = nombre;
            this.noVelas = noVelas;
        }

        //Métodos propios de la interface
        public bool Anclar()
        {
            ancla = false;
            return ancla;
        }

        public void Avanzar()
        {
            Console.WriteLine("El " + nombre + " está avanzando");
        }

        public bool Desanclar()
        {
            ancla = true;
            return ancla;
        }

        public void GirarBabor()
        {
            Console.WriteLine("El " + nombre + " gira a babor");
        }

        public void GirarEstribor()
        {
            Console.WriteLine("El " + nombre + " gira a estribor");
        }

        //Sobreescritura del método ToString
        public override String ToString()
        {
            return "Nombre: " + nombre + " | " + "No. velas: " + noVelas;
        }
    }
}
