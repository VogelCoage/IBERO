using System;
namespace proyectoAuto
{
    //Los : fungen como el "extends" en JAVA para convertir una clase en hija de otra
    public class Camion : Auto 
    {
        public int noPasajeros;

        /*Constructor que invoca al constructor vacío de la clase padre y además
        * inicializa el atributo de esta clase
        */       
        public Camion() : base()
        {
            noPasajeros = 0;
        }

        //Sobrecarga del constructor invocando al constructor padre que acepta 4 argumentos
        public Camion(String marca, String modelo, String color) : base(marca, modelo, color)
        {
            noPasajeros = 0;
        }

        //Sobrecarga del constructor invocando al constructor padre que acepta 4 argumentos
        public Camion(String marca, String modelo, String color, int noPuertas) : base(marca, modelo, color, noPuertas)
        {
            noPasajeros = 0;
        }

        //Sobrecarga del constructor invocando al constructor padre que acepta 4 argumentos
        public Camion(String marca, String modelo, String color, int noPuertas,
         int noPasajeros):base(marca, modelo, color, noPuertas)
        {
            this.noPasajeros = noPasajeros;
        }

        public override string Pitar() //Aquí en lugar de override, funcionó "new"
        {
            return "El camión está pitando muy fuerte!!!";
        }

        //Sobreescribiendo el metodo ToString
        public override string ToString()
        {
            return base.ToString() + " " + "No. de pasajeros: " + noPasajeros;
        }
    }
}
