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


        public int agregarEjercicioAPlan(string Cedula, string Padecimiento, string Nivel, string nombreEjerc, int tiempo, int repeticiones)
        {
            String insertar = "insert into CONSTA_DE (CedPaciente, Padec_Act, Nivel_Plan, Nombre_Eje, Tiempo, Repeticion)  " +
                "VALUES ('" + Cedula + "','" + Padecimiento + "','" + Nivel + "','" + nombreEjerc + "','" + tiempo + "','" + repeticiones + "')";
            return bd.actualizarDatos(insertar);
        }

        public int agregarTarea(string Cedula, string Padecimiento, string Nivel, string tarea)
        {
            String insertar = "insert into TAREAS_PLAN_EJERCICIOS (CedPaciente, Padec_Act, Nivel_Plan, Tarea)  " +
                "VALUES ('" + Cedula + "','" + Padecimiento + "','" + Nivel + "','" + tarea + "')";
            return bd.actualizarDatos(insertar);
        }

        //obtenemos una lista de nombre de los planes de tratamiento asociados a un paciente
        public SqlDataReader obtenerListaPadecimiento(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select distinct Pad_Actual  from PLAN_TRATAMIENTO   where CedPaciente = '" + cedula + "'");
            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        /*Método para agregar un nuevo Plan de Ejercicio a la base de datos
            Recibe: Los datos del nuevo los plan de ejercicio
            Modifica: inserta en la base de datos el nuevo Plan de Ejercicio
            Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
        */
        public int agregarPlanEjercicio(string Cedula, string Padecimiento, string Nivel, string Objetivos)
        {
            String insertar = "insert into PLAN_EJERCICIOS (CedPaciente, Padec_Act, Nivel, Objetivos)  " +
                "VALUES ('" + Cedula + "','" + Padecimiento + "','" + Nivel + "','" + Objetivos + "')";
            return bd.actualizarDatos(insertar);
        }

        /*Método para obtener las tareas de un plan de ejercicios*/

        public DataTable obtenerTareas(string cedula, string padecimiento, string nivel)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("Select Tarea from TAREAS_PLAN_EJERCICIOS " +
                    "where CedPaciente = '" + cedula + "' and Padec_Act = '" + padecimiento + "' and Nivel_Plan = '" + nivel + "'");
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método para obtener los planes de ejercicios de la base de datos usando la cédula*/

        public DataTable obtenerPlanEjercicios(string cedula)
        {
            DataTable tabla = null;
            try
            {                 
                tabla = bd.ejecutarConsultaTabla("Select * from plan_ejercicios where CedPaciente = '" + cedula + "'");                
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método para obtener los planes de ejercicios de la base de datos usando la cédula*/

        public DataTable obtenerEjerciciosDePlan(string cedula, string Padecimiento, string Nivel)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("Select Nombre_Eje, Tiempo, Repeticion from CONSTA_DE " +
                    "where CedPaciente = '" + cedula + "' and Padec_Act = '" + Padecimiento + "' and Nivel_Plan = '" + Nivel + "'");
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método para eliminar un plan de ejercicio mediante el procedimiento almacenado
            Recibe: la cedula del paciente, nombre del padecimiento(plan de tratamiento) y nivel del plan de ejercicio
            Modifica: Llama al método que elimina el plan de ejercicio mediante la llave primaria
            Retorna: el tipo de error que generó el eliminar o cero si el eliminar fue exitoso
       */
        public int eliminarPlanEjercicio(string cedula, string padecAct, string nivel)
        {
            String eliminar = "EXEC eliminarPlanEjercicio '" + cedula + "', '" + padecAct + "', '" + nivel + "'";
            return bd.actualizarDatos(eliminar);
        }
    }
}
