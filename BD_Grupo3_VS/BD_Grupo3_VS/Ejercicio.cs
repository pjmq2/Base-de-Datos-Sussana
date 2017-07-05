using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BD_Grupo3_VS
{ 
    class Ejercicio
    {
        AccesoBaseDatos bd;
        public Ejercicio()
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
        }

        /*Método para agregar un nuevo ejercicio a la base de datos
            Recibe: Los datos del nuevo ejercicio
            Modifica: inserta en la base de datos el nuevo ejercicio
            Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
        */
        public int agregarEjercicio(string nombre, string descripcion, Image imagen)
        {
            String insertar = "Insert into Ejercicio (Nombre, Descripcion, Imagen) VALUES ("+nombre+","+descripcion+","+imagen+")";
            return bd.actualizarDatos(insertar);
        }

        /*Metodo para obtener los nombres de los ejercicios en la base de datos
            Recibe: Nada
            Realiza la selección de los nombres de ejercicios y lo carga en un dataReader
            Retorna: el dataReader con los datos
        */
        public SqlDataReader obtenerListaNombresEjercicios()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select distinct Nombre from Ejercicio");
            }
            catch (SqlException ex)
            { }
            return datos;
        }

        /*Método para obtener los ejercicios de la base de datos
            Recibe: dos tipos de filtros por los cuales se pueden filtrar las tuplas
            Modifica: Realiza la selección de los ejercicios y los carga en un dataTable
            Retorna: el dataTable con los datos
        */
        public DataTable obtenerEjercicios(string filtroNombre)
        {
            DataTable tabla = null;
            try
            {
                if (filtroNombre==null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from ejercicio");
                }
                else if (filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from ejercicio where nombre = '" + filtroNombre+ "'");
                }
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método para eliminar un ejercicio mediante el procedimiento almacenado
            Recibe: El nombre de los ejercicios o ejercicio a eliminar
            Modifica: Llama al método que elimina el ejercicio mediante el nombre
            Retorna: el tipo de error que generó el eliminar o cero si el eliminar fue exitoso
        */
        public int eliminarejercicio(string nombre)
        {
            return bd.eliminarEstudiante(nombre);
        }
    }
}
