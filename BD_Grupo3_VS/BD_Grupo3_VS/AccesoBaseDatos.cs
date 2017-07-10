using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/*Cambiar el namespace para que funcione!!*/
namespace BD_Grupo3_VS
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog=gaudyblanco; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        string conexion = "Data Source=10.1.4.55;User ID=B33925;Password=B33925; Initial Catalog=DB_Grupo3; Integrated Security=false";

        /**
         * Constructor de la clase
         */
        public AccesoBaseDatos()
        {
        }

        public void subirImagen(string nombre, byte[] img)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)//check whether connection to database is close or not
                    sqlConnection.Open();//if connection is close then only open the connection
                SqlCommand cmd = new SqlCommand("SaveImage", sqlConnection);//create a SQL command object by passing name of the stored procedure and database connection 
                cmd.CommandType = CommandType.StoredProcedure; //set command object command type to stored procedure type
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = nombre;//add parameter to the command object and set value to that parameter
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = img;//add parameter to the command object and set value to that parameter
                cmd.ExecuteNonQuery();//execute command
                //MessageBox.Show("Image guardada exitosamente!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
            }
            catch (Exception ex)//catch if any error occur
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);//display error message with exception 
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)//check whether connection to database is open or not
                    sqlConnection.Close();//if connection is open then only close the connection
            }
        }

        public Image recuperarImagen(string nombre)
        {
            Image imagen = null;
            SqlConnection sqlConnection = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("ReadImage", sqlConnection);//create a SQL command object by passing name of the stored procedure and database connection 
            cmd.CommandType = CommandType.StoredProcedure; //set command object command type to stored procedure type
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = nombre;//add parameter to the command object and set value to that parameter
            SqlDataAdapter adp = new SqlDataAdapter(cmd);//create SQL data adapter with command object
            DataTable dt = new DataTable();//create a data table to hold result of the command
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)//check whether connection to database is close or not
                    sqlConnection.Open();//if connection is close then only open the connection
                adp.Fill(dt);//data table fill with data by calling the fill method of data adapter object
                if (dt.Rows.Count > 0)//check whether data table contain any row or not
                {
                    MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Imagen"]);//create memory stream by passing byte array of the image
                    imagen = Image.FromStream(ms);//set image property of the picture box by creating a image from stream 
                }
            }
            catch (Exception ex)//catch if any error occur
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display error message with exception 
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)//check whether connection to database is open or not
                    sqlConnection.Close();//if connection is open then only close the connection
            }
            return imagen;
        }

        public void subirArchivo(string cedula, string dato, byte[] archivo)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)//check whether connection to database is close or not
                    sqlConnection.Open();//if connection is close then only open the connection
                SqlCommand cmd = new SqlCommand("SaveFile", sqlConnection);//create a SQL command object by passing name of the stored procedure and database connection 
                cmd.CommandType = CommandType.StoredProcedure; //set command object command type to stored procedure type
                cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;//add parameter to the command object and set value to that parameter
                cmd.Parameters.Add("@Dato", SqlDbType.VarChar).Value = dato;//add parameter to the command object and set value to that parameter
                cmd.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = archivo;//add parameter to the command object and set value to that parameter
                cmd.ExecuteNonQuery();//execute command
                MessageBox.Show("Archivo guardado exitosamente!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
            }
            catch (Exception ex)//catch if any error occur
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);//display error message with exception 
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)//check whether connection to database is open or not
                    sqlConnection.Close();//if connection is open then only close the connection
            }

        }

        public byte[] recuperarArchivo(string cedula, string dato)
        {
            byte[] archivo = null;
            SqlConnection sqlConnection = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("ReadFile", sqlConnection);//create a SQL command object by passing name of the stored procedure and database connection 
            cmd.CommandType = CommandType.StoredProcedure; //set command object command type to stored procedure type
            cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;//add parameter to the command object and set value to that parameter
            cmd.Parameters.Add("@Dato", SqlDbType.VarChar).Value = dato;//add parameter to the command object and set value to that parameter
            SqlDataAdapter adp = new SqlDataAdapter(cmd);//create SQL data adapter with command object
            DataTable dt = new DataTable();//create a data table to hold result of the command
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)//check whether connection to database is close or not
                    sqlConnection.Open();//if connection is close then only open the connection
                adp.Fill(dt);//data table fill with data by calling the fill method of data adapter object
                if (dt.Rows.Count > 0)//check whether data table contain any row or not
                {
                    archivo=(byte[])dt.Rows[0]["Archivo"];//create memory stream by passing byte array of the file
                }
            }
            catch (Exception ex)//catch if any error occur
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//display error message with exception 
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)//check whether connection to database is open or not
                    sqlConnection.Close();//if connection is open then only close the connection
            }
            return archivo;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datareader con los resultados de la ejecución de la consulta
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         * * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datatable con los resultados de la ejecución de la consulta
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);


            return table;
        }

        /*Método para ejecutar un insert, update o delete 
         Recibe: la sentencia sql a ejecutar
         Modifica: realiza el cambio en la base de datos de acuerdo al tipo de sentencia sql
         Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa*/
        public int actualizarDatos(String consulta)
        {
            int error = 0;
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand cons = new SqlCommand(consulta, sqlConnection);

            try
            {
                //Ejecuta la consulta sql recibida por parámetro
                cons.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }

            finally
            {
                sqlConnection.Close();
            }

            return error;
        }

        /*Método para llamar al procedimiento almacenado de eliminarEstudiante 
         Recibe: el nombre del o los estudiantes que se va a eliminar
         Modifica: Elimina las tuplas que coincidan con el nombre recibido por parámetro
         Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa*/
        public int eliminar(string eliminado)
        {
            int error = 0;
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            SqlCommand comando = new SqlCommand(eliminado, sqlConnection);
            sqlConnection.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }
            finally
            {
                sqlConnection.Close();
            }

            return error;

        }

        #region Eliminación de Técnica, Material y Requiere_De
        public int eliminarTecnica(string nombre)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("eliminarTecnica", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        con.Open();

                        cmd.ExecuteNonQuery();
                        return error;
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int eliminarMaterial(string nombre)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("eliminarMaterial", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        con.Open();

                        cmd.ExecuteNonQuery();
                        return error;
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int eliminarRequiereDe(string nombreTec, string nombreMat)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("eliminarRequiereDe", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@nombreTec", SqlDbType.VarChar).Value = nombreTec;
                        cmd.Parameters.Add("@nombreMat", SqlDbType.VarChar).Value = nombreMat;

                        con.Open();

                        cmd.ExecuteNonQuery();
                        return error;
                    }
                    catch (SqlException ex)
                    {
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }
        #endregion

        /*Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
         Recibe: el usuario y la contraseña del nuevo usuario
         Modifica: Agrega en la base de datos un nuevo usuario
         Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
         si no se pudo insertar*/
        public int agregarUsuario(string usuario, string password)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("agregarUsuario", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLogin", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@estado"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        /*Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
         Recibe: El usuario y contraseña que se desea verificar que está en la base de datos
         Modifica: Busca el usuario con esa contraseña en la base de datos
         Retorna: true si está en la base de datos, false sino*/
        public bool login(string usuario, string password)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("Login", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLoginName", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@isInDB", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@isInDB"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }

        }

    }
}