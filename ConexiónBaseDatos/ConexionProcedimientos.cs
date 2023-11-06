using TODOLIST_AGA.Models;
using System.Data.SqlClient;
using System.Data;




namespace TODOLIST_AGA.ConexiónBaseDatos

{
    public class ConexionProcedimientos
    {
        public List<ParametrosEntrada> Consultar()
        {
            var lect = new List<ParametrosEntrada>();

            var conecT = new ConexionABasedeDatos();

            using (var conex = new SqlConnection(conecT.getconexionAsql()))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("CONSULTATOTAL", conex);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var lecturaLista = cmd.ExecuteReader())
                {
                    while (lecturaLista.Read())
                    {
                        lect.Add(new ParametrosEntrada()
                        {
                            ID = Convert.ToInt32(lecturaLista["ID"]),
                            Nombre = lecturaLista["Nombre"].ToString(),
                            Actividad = lecturaLista["Actividad"].ToString(),
                            Estatus = lecturaLista["Estatus"].ToString()
                        });
                    }
                }

            }
            return lect;
        }

        public ParametrosEntrada Obtener(int ID)
        {
            var nuevo = new ParametrosEntrada();

            var conecT = new ConexionABasedeDatos();

            using (var conex = new SqlConnection(conecT.getconexionAsql()))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("OBTENERUSUARIO", conex);
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var lecturaLista = cmd.ExecuteReader())
                {
                    while (lecturaLista.Read())
                    {

                        nuevo.ID = Convert.ToInt32(lecturaLista["ID"]);
                        nuevo.Nombre = lecturaLista["Nombre"].ToString();
                        nuevo.Actividad = lecturaLista["Actividad"].ToString();
                        nuevo.Estatus = lecturaLista["Estatus"].ToString();

                    }
                }

            }
            return nuevo;
        }

        public bool Agregar(ParametrosEntrada parametros_SP_01)
        {
            bool a;
            try
            {
                var conecT = new ConexionABasedeDatos();

                using (var conex = new SqlConnection(conecT.getconexionAsql()))
                {
                    conex.Open();

                    SqlCommand cmd = new SqlCommand("GUARDARUSUARIO", conex);
                    cmd.Parameters.AddWithValue("Nombre", parametros_SP_01.Nombre);
                    cmd.Parameters.AddWithValue("Actividad", parametros_SP_01.Actividad);
                    cmd.Parameters.AddWithValue("Estatus", parametros_SP_01.Estatus);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                a = true;

            }
            catch (Exception e)
            {
                string ermsg = e.Message;
                a = false;
            }

            return a;

        }

        public bool Actualizar(ParametrosEntrada parametros_SP_01)
        {
            bool a;
            try
            {
                var conecT = new ConexionABasedeDatos();

                using (var conex = new SqlConnection(conecT.getconexionAsql()))
                {
                    conex.Open();

                    SqlCommand cmd = new SqlCommand("ACTUALIZAR", conex);
                    cmd.Parameters.AddWithValue("ID", parametros_SP_01.ID);
                    cmd.Parameters.AddWithValue("Nombre", parametros_SP_01.Nombre);
                    cmd.Parameters.AddWithValue("Actividad", parametros_SP_01.Actividad);
                    cmd.Parameters.AddWithValue("Estatus", parametros_SP_01.Estatus);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                a = true;

            }
            catch (Exception e)
            {
                string ermsg = e.Message;
                a = false;
            }

            return a;
        }

        public bool Eliminar(int ID)
        {
            bool a;
            try
            {
                var conecT = new ConexionABasedeDatos();

                using (var conex = new SqlConnection(conecT.getconexionAsql()))
                {
                    conex.Open();

                    SqlCommand cmd = new SqlCommand("ELIMINAR", conex);
                    cmd.Parameters.AddWithValue("ID", ID);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                a = true;

            }
            catch (Exception e)
            {
                string ermsg = e.Message;
                a = false;
            }

            return a;
        }

       
    }
}




    

