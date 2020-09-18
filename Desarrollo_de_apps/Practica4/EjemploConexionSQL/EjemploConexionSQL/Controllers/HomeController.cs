using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Data.SqlClient;  //librería para el uso de sql-server

namespace EjemploConexion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string cadConect = @"Server=localhost;User=sa;Password=Repstalker1;Database=rescate_imposible;";
            SqlConnection mi_conexion = new SqlConnection(cadConect);

            try
            {
                mi_conexion.Open(); //Abre la conexion a la base de datos "Escuelita"
                Console.WriteLine("Me conecte a la base!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                mi_conexion.Close();
            }
            Console.ReadKey();
        }
    }
}