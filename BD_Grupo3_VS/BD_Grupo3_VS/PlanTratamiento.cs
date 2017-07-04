using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
{

    class PlanTratamiento
    {
        AccesoBaseDatos bd;
        public PlanTratamiento()
        {
            bd = new AccesoBaseDatos();
        }
        
        public int agregaPlanTratamiento(string cedula,string padecimiento,string observ)
        {
            String insertar = "INSERT into PLAN_TRATAMIENTO (CedPaciente, Pad_Actual, Objetivos)" +
                 " VALUES (" + cedula + ",'" + padecimiento + "','" + observ + "' )";
            return bd.actualizarDatos(insertar);
        }

        public DataTable consultarPlanTratamiento(string cedula, string padecimiento)
        {
            DataTable tabla = null;
            try
            {
                //Caso en que se desea mostrar todos los registros
                if(cedula == null && padecimiento == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select distinct CedPaciente, NombreP, Apellido1, Apellido2, Pad_Actual, Objetivos" +
                        " from Plan_Tratamiento join Paciente on Cedula = CedPaciente");
                }
                //Búsqueda por cédula
                else if(cedula != null && padecimiento == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select distinct CedPaciente, NombreP, Apellido1, Apellido2, Pad_Actual, Objetivos" +
                        " from Plan_Tratamiento join Paciente on Cedula = CedPaciente where CedPaciente LIKE '%" + cedula + "%'");
                }
                //Búsqueda por padecimiento
                else if(cedula == null && padecimiento != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select distinct CedPaciente, NombreP, Apellido1, Apellido2, Pad_Actual, Objetivos" +
                        " from Plan_Tratamiento join Paciente on Cedula = CedPaciente where Pad_Actual LIKE '%" + padecimiento + "%'");
                }
                //Búsqueda por ambos campos
                else if(cedula != null && padecimiento != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select distinct CedPaciente, NombreP, Apellido1, Apellido2, Pad_Actual, Objetivos" +
                        " from Plan_Tratamiento join Paciente on Cedula = CedPaciente where CedPaciente LIKE '%" + cedula + "%' OR Pad_Actual LIKE '%" + padecimiento + "%' ");
                }
            }catch(SqlException ex)
            {

            }
            return tabla;
        }
    }
}