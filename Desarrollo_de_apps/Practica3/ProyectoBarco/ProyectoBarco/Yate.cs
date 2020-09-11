using System;
namespace ProyectoBarco
{
    /*Nueva clase Yate, hija de la clase Lancha por lo que hereda atributos y
    * métodos de las clases Barco y Lancha y desde luego la implementación de
    * la interface Navegacion
    */   
    public class Yate : Lancha, INavegacion
    {
        //Nuevos atributos que se agregan a los que ya hereda
        public int noCubiertas;
        public int noPasajeros;

        //Constructor por defecto (sin argumentos)
        public Yate()
        {
            nombre = "Yate privado";
            noVelas = 0;
            motor = "Dentro de borda";
            noCubiertas = 1;
            noPasajeros = 5;
        }

        /*Sobrecarga del constructor (con 2 argumentos), por lo que se invoca al
         * constructor de la clase padre de 2 argumentos
         */
        public Yate(string nombre, int noVelas) : base(nombre, noVelas)
        {
            noCubiertas = 1;
            noPasajeros = 5;
        }

        /*Sobrecarga del constructor (con 3 argumentos), por lo que se invoca al
         * constructor de la clase padre de 3 argumentos
         */
        public Yate(string nombre, int noVelas, string motor) : base(nombre, noVelas, motor)
        {
            noCubiertas = 1;
            noPasajeros = 5;
        }

        /*Sobrecarga del constructor (con 5 argumentos), por lo que se invoca al
         * constructor de la clase padre de 3 argumentos + los dos propios de la clase
         */
        public Yate(string nombre, int noVelas, string motor, int noCubiertas,
         int noPasajeros) : base(nombre, noVelas, motor)
        {
            this.noCubiertas = noCubiertas;
            this.noPasajeros = noPasajeros;
        }

        //Se declara de nueva cuenta el método Avanzar, con new en lugar de override
        public override void Avanzar()
        {
            Console.WriteLine("El " + nombre + " avanza muy rápido!!!");
        }

        /*Una vez más se sobrescribe el método ToString invocando al mismo método
        * de la clase padre, pero agregando los nuevos atributos
        */       
        public override string ToString()
        {
            return base.ToString() + " | " + " No de cubiertas: " + noCubiertas +
             " | " + " No. de pasajeros: " + noPasajeros;
        }
    }
}
