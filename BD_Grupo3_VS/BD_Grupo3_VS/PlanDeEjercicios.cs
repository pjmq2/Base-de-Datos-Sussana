using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    class PlanDeEjercicios
    {
        AccesoBaseDatos bd;

        public PlanDeEjercicios()
        {
            bd = new AccesoBaseDatos();
        }

        /*Método para agregar un nuevo Plan de Ejercicio a la base de datos
            Recibe: Los datos del nuevo los plan de ejercicio
            Modifica: inserta en la base de datos el nuevo Plan de Ejercicio
            Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
        */
        public int agregarPlanEjercicio(string Cedula, string Padecimiento, string Nivel, string Objetivos)
        {
            String insertar = "Insert into Plan_Ejercicios (CedPaciente, Pad_Actual, Nivel, Objetivos) VALUES ('" + Cedula + "','" + Padecimiento + "','" + Nivel + "','" + Objetivos + "')";
            return bd.actualizarDatos(insertar);
        }

        /*Metodo para obtener los nombres de los planes de ejercicios en la base de datos
            Recibe: Nada
            Realiza la selección de los nombres delos planes de  ejercicios y lo carga en un dataReader
            Retorna: el dataReader con los datos
        */
        public SqlDataReader obtenerListaNombresPlanesEjercicios()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select distinct Nombre from Plan_Ejercicio");
            }
            catch (SqlException ex)
            { }
            return datos;
        }

        /*Método para obtener los planes de ejercicios de la base de datos
            Recibe: dos tipos de filtros por los cuales se pueden filtrar las tuplas
            Modifica: Realiza la selección de los plan de ejercicios y los carga en un dataTable
            Retorna: el dataTable con los datos
        */
        public DataTable obtenerPlanEjercicios(string filtroCedula, string filtroPadecimiento, string filtroNivel, string filtro1)
        {
            DataTable tabla = null;
            try
            {
                if ((filtroCedula == null) && (filtroPadecimiento == null) && (filtroNivel == null) && (filtro1 == null))
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios");
                }
                else if ((filtroCedula != null) && (filtroPadecimiento != null) && (filtroNivel != null) && (filtro1 != null))
                {

                }
                else if (filtroCedula != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios where CedPaciente = '" + filtroCedula + "' OR CedPaciente like '%" + filtro1 + "%' OR Pad_Actual = '" + filtroPadecimiento + "' OR Pad_Actual like '%" + filtro1 + "%' OR Nivel = '" + filtroNivel + "' OR Nivel like '%" + filtro1 + "%' OR Objetivos like '%" + filtroNivel + "%'");
                }
                else if (filtroPadecimiento != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios where Pad_Actual = '" + filtroPadecimiento + "'");
                }
                else if (filtroNivel != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios where Nivel = '" + filtroNivel + "'");
                }
                else if (filtro1 != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios where Objetivos like '%" + filtroNivel + "%'");
                }
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método para eliminar un plan de ejercicio mediante el procedimiento almacenado
            Recibe: El nombre de los planes de ejercicios a eliminar
            Modifica: Llama al método que elimina el plan de ejercicio mediante el nombre
            Retorna: el tipo de error que generó el eliminar o cero si el eliminar fue exitoso
        */
        public int eliminarPlanEjercicio(string nombre)
        {
            return 1;
        }


    }
}
