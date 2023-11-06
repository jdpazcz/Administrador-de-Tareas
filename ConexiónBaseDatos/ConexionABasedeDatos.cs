using System.Data.SqlClient;

namespace TODOLIST_AGA.ConexiónBaseDatos
{
    public class ConexionABasedeDatos
    {
        private string conexionAsql = string.Empty;
        public ConexionABasedeDatos()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            conexionAsql = builder.GetSection("ConnectionStrings:Conexion").Value;

        }
        public string getconexionAsql()
        {
            return conexionAsql;
        }
    }





}
