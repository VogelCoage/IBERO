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
        public static string cadConect = @"Server=localhost;User=sa;Password=Repstalker1;Database=Escuelita;";

        public static void Main(string[] args)
        {
            //consultar();

            //insertaRegistro();

            insertaRegIngr();
            
            Console.ReadKey();
        }
        //Método para ingresar un registro de alumno desde teclado
        public static void insertaRegIngr()
        {
            SqlConnection conecta = new SqlConnection(cadConect);
            SqlCommand nuevo_comando = new SqlCommand();
            //Se crean las variables para ingresar los datos
            string nom, apPat, apMat;
            int edad;

            try
            {
                //Se abre la conexión
                conecta.Open();
                Console.WriteLine("Registro de nuevo alumno en la base de datos \"Mi escuelita\"");
                Console.WriteLine("===========================================================");
                //Petición e ingreso de datos
                Console.WriteLine("Ingresa el nombre: ");
                nom = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido paterno: ");
                apPat = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido materno: ");
                apMat = Console.ReadLine();
                Console.WriteLine("Ingresa la edad: ");
                edad = int.Parse(Console.ReadLine());
                //Asignación de la conexión al objeto de tipo SqlCommand
                nuevo_comando.Connection = conecta;
                //Asignación de la instrucción al objeto de tipo SqlCommand
                nuevo_comando.CommandText = "INSERT INTO Alumnos VALUES('" + nom + "', '" + apPat + "', '" + apMat + "'," + edad + ")";
                //Se ejecuta el comando
                nuevo_comando.ExecuteNonQuery();
                //Mensaje impreso después de un registro exitoso
                Console.WriteLine("El registro se insertó con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conecta.Close();
            }
        }

        public static void insertaRegistro()
        {
            //Se crea el objeto SqlConnection para establecer la conexión
            SqlConnection conecta = new SqlConnection(cadConect);
            //Se crea el objeto SqlCommand para ejecutar comandos sql
            SqlCommand nuevo_comando = new SqlCommand();

            try
            {
                //Se abre la conexión
                conecta.Open();
                //Se asigna la conexión al objeto comando
                nuevo_comando.Connection = conecta;
                //Se asigna una linea de comando (cadena) al comando
                nuevo_comando.CommandText = "INSERT INTO Alumnos VALUES('Petronila', 'Mendoza', 'Perez', 18)";
                //Se ejecuta el comando
                nuevo_comando.ExecuteNonQuery(); //Ejecuta y no devuelve datos
                //Se imprime el mensaje en caso de registro exitoso
                Console.WriteLine("El registro se insertó con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conecta.Close();
            }

            Console.ReadKey();
        }

        public static void consultar()
        {
            //string cadConect = @"Server=localhost;User=sa;Password=Repstalker1;Database=Escuelita;";
            SqlConnection mi_conexion = new SqlConnection(cadConect);
            //Se crea un comando de SQL y un lector SQL
            SqlCommand mi_comando = null;
            SqlDataReader mi_lector = null;

            try
            {
                mi_conexion.Open(); //Abre la conexion a la base de datos "Escuelita"
                Console.WriteLine("Me conecte a la base!!!");

                //Se inicializa el objeto con la conexión abierta
                mi_comando = new SqlCommand("SELECT * FROM Alumnos", mi_conexion);
                //Se inicializa el lector de SQL
                mi_lector = mi_comando.ExecuteReader(); //Ejecuta el comando y devuelve datos

                //Ciclo para mostrar todos los registros del objeto "mi_lector"
                while (mi_lector.Read())
                {
                    Console.WriteLine(" {0} {1} {2} {3} {4}", mi_lector[0], mi_lector[1], mi_lector[2], mi_lector[3], mi_lector[4]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                mi_conexion.Close();
            }
        }
    }
}