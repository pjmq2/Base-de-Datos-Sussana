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
                datos = bd.ejecutarConsulta("Select distinct Dato from DATOS_CLINICOS");
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
        public int eliminarejercicio(string nombre)
        {
            string mensaje = "delete from ejercicio where nombre = '" + nombre + "'";
            return bd.eliminar(mensaje);
        }

        /*Método para obtener la descripcion de un Dato Clinico 
            Recibe: El nombre de los Dato Clinicos 
            Modifica: Realiza la selección del Dato Clinico y carga la descripcion
            Retorna: La descripcion del Dato Clinico
        */
        public string obtenerDescripcion(string nombre)
        {
            string descripcion = "";
            SqlDataReader datos = null;
            datos = bd.ejecutarConsulta("Select * from ejercicio where nombre = '" + nombre + "'");
            descripcion = datos.GetString(2);
            return descripcion;
        }
        /*
        public Image obtenerImagen(string nombre)
        {
            Image imagen = null;
            imagen = bd.recuperarImagen(nombre);
            return imagen;
        }

        public int modificarDescripcion(string nombre, string descripcion)
        {
            string consulta = "update ejercicio set descripcion = '" + descripcion + "' where nombre = '" + nombre + "'";
            return bd.actualizarDatos(consulta);
        }

        public byte[] obtenerArchivo(string cedula, string dato)
        {
            byte[] archivo=bd.recuperarArchivo(cedula, dato);
            return archivo;
        }

        public void insertarImagen(string nombre, byte[] imagen)
        {
            bd.subirImagen(nombre, imagen);
        }

        public int modificarNombre(string nombre, string nombreNuevo)
        {
            string modificacion = "update Ejercicio set nombre = '" + nombreNuevo + "' where nombre = '" + nombre + "'";
            return bd.actualizarDatos(modificacion);
        }
        */
    }
}
