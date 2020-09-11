using System;

namespace ProyectoBarco
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Se instancian los objetos de tipo Barco, Lancha y Yate
            Barco navio = new Barco("SS Sotavento", 2);
            Lancha pesca = new Lancha();
            Yate xclusive = new Yate("Estrella marina", 0);

            /*Se aplican los distintos métodos que funcionan de manera particular
            * en cada objeto según la clase
            */     
            Console.WriteLine(navio.ToString());
            navio.Avanzar();
            navio.GirarBabor();
            navio.GirarEstribor();
            Console.WriteLine("Ancla levantada: " + navio.Anclar() + " | " + "El " +
             navio.nombre + " ha arribado!!!");
            Console.WriteLine("Ancla levantada: " + navio.Desanclar() + " | " + "El " +
             navio.nombre + " ha sarpado!!!\n");

            Console.WriteLine(pesca.ToString());
            Console.WriteLine("Ancla levantada: " + pesca.Desanclar() + " | " + "El " +
             pesca.nombre + " ha sarpado!!!");
            pesca.Avanzar();
            pesca.GirarBabor();
            pesca.GirarEstribor();
            Console.WriteLine("Ancla levantada: " + pesca.Anclar() + " | " + "El " +
             pesca.nombre + " ha arribado!!!\n");

            Console.WriteLine(xclusive.ToString());
            Console.WriteLine("Ancla levantada: " + xclusive.Desanclar() + " | " +
             "El " + xclusive.nombre + " ha sarpado!!!");
            xclusive.GirarEstribor();
            xclusive.Avanzar();
            xclusive.GirarBabor();
            Console.WriteLine("Ancla levantada: " + xclusive.Anclar() + " | " + "El " +
             xclusive.nombre + " ha arribado!!!");
            Console.ReadKey();
        }
    }
}
