using System;
namespace ProyectoBarco
{
    //Interface
    public interface Navegacion
    {
        //Métodos propios de la interface
        void Avanzar();
        void GirarEstribor();
        void GirarBabor();
        bool Anclar();
        bool Desanclar();
    }
}
