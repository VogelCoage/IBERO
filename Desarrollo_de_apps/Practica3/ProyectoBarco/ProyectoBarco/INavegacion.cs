using System;
namespace ProyectoBarco
{
    //Interface
    public interface INavegacion
    {
        //Métodos propios de la interface
        void Avanzar();
        void GirarEstribor();
        void GirarBabor();
        bool Anclar();
        bool Desanclar();
    }
}
