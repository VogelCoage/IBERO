using System;
namespace ProyectoBarco
{
    /*Clase Lancha, hija de la clase barco, heredando sus atributos y métodos
    *(incluyendo la implementación de la interface)
    */
    public class Lancha : Barco
    {
        //Nuevo atributo de clase
        protected string motor;

        //Constructor primario (sin argumentos)
        public Lancha()
        {
            nombre = "Bote de pesca";
            noVelas = 0;
            motor = "Fuera de borda";
        }

        /*Sobrecarga del constructor con 3 argumentos
        *que invoca al constructor de la clase padre con 2 argumentos
        **/       
        public Lancha(string nombre, int noVelas, string motor) : base(nombre, noVelas)
        {
            this.motor = motor;
        }

        /*Sobrescritura del método ToString, invocando al método ToString de la
        * clase padre y agregándole el nuevo atributo
        */       
        public override string ToString()
        {
            return base.ToString() + " | " + "Motor: " + motor;
        }
    }
}
