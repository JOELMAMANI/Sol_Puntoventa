using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//luis de aqui
namespace Sol_puntoventas.datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "BD_PUNTOVENTA";
            this.Servidor = "DESKTOP-JCBA09I\\SQLEXPRESS";
            this.Usuario = "userp";
            this.Clave = "1402";
        }

        public SqlConnection CrearConexion() 
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "server=" + this.Servidor +

                                          "; DataBase" + this.Base +
                                          "; User Id" +this.Usuario +
                                          "; Password=" +this.Clave;
            }
            catch (Exception ex)
            {

                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
//luis hasta aqui