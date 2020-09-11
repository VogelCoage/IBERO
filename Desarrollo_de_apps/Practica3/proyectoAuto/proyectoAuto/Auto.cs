using System;
namespace proyectoAuto
{
    //Declaración de la clase
    public class Auto
    {
        public string marca;
        public string modelo;
        public string color;
        public int noPuertas;
        private double kilometraje;
        private double posicion;

        //Constructor
        public Auto()
        {
            noPuertas = 4;
            kilometraje = 0;
            posicion = 0;
        }

        //Sobrecarga del costructor
        public Auto(String marca, String modelo, String color):this() //Se invoca al constructor anterior
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
        }

        //Nueva sobrecarga y además se invoca al constructor anterior
        public Auto(String marca, String modelo, String color, int noPuertas):this(marca, modelo, color)
        {
            this.noPuertas = noPuertas;
        }

        /*Nuevo método implementado en la clase Auto. Se usa la palabra "virtual" para que las clases
        *hijas lo puedan modificar
        */       
        public virtual string Pitar()
        {
            return "El " + marca + " está pitando";
        }

        //Métodos que modifican la posición
        public void avanza(double distancia)
        {
            kilometraje += distancia;
            posicion += distancia;
        }

        public void retrocede(double distancia)
        {
            kilometraje += distancia;
            posicion -= distancia;
        }

        //Sobrecarga del método ToString
        public override string ToString()
        {
            return marca + " " + modelo + " " + color + " | " + kilometraje + "km x=" + posicion;
        }
    }
}
