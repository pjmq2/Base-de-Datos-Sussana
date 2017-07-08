using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
{
    class DatosClinicos
    {
        AccesoBaseDatos bd;
        string cedula;
        public DatosClinicos(string cedulaNueva)
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
            cedula = cedulaNueva;
        }


        /*Método para agregar un nuevo Dato Clinico a la base de datos
            Recibe: Los datos del nuevo Dato Clinico
            Modifica: inserta en la base de datos el nuevo Dato Clinico
            Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
        */
        public int agregarDato (string dato)
        {
            string insertar = "Insert into DATOS_CLINICOS (CedPaciente, Dato, Archivo) VALUES ('" + cedula + "','" + dato + "',null)";
            return bd.actualizarDatos(insertar);
        }

        /*Metodo para obtener los nombres de los Dato Clinicos en la base de datos
            Recibe: Nada
            Realiza la selección de los nombres de Dato Clinicos y lo carga en un dataReader
            Retorna: el dataReader con los datos
        */
        public SqlDataReader obtenerLista()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select distinct Dato from DATOS_CLINICOS where CedPaciente ='"+cedula+"'");
            }
            catch (SqlException ex)
            { }
            return datos;
        }

       
        /*Método para eliminar un Dato Clinico mediante el procedimiento almacenado
            Recibe: El nombre de los Dato Clinicos o Dato Clinico a eliminar
            Modifica: Llama al método que elimina el Dato Clinico mediante el nombre
            Retorna: el tipo de error que generó el eliminar o cero si el eliminar fue exitoso
        */
        public int eliminarDato(string cedula, string dato)
        {
            string mensaje = "delete from DATOS_CLINICOS where CedPaciente = '" + cedula + "' AND Dato = '" +dato+ "'";
            return bd.eliminar(mensaje);
        }

        public byte[] obtenerArchivo(string dato)
        {
            byte[] archivo=bd.recuperarArchivo(cedula, dato);
            return archivo;
        }

        public void insertarArchivo(string dato, byte[] archivo)
        {
            bd.subirArchivo(cedula, dato, archivo);

        }
        
    }
}
