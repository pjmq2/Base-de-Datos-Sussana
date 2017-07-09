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
            String insertar = "insert into PLAN_EJERCICIOS (CedPaciente, Padec_Act, Nivel, Objetivos)  VALUES ('" + Cedula + "','" + Padecimiento + "','" + Nivel + "','" + Objetivos + "')";
            return bd.actualizarDatos(insertar);
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
