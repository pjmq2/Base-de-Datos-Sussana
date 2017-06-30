using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitaPlanTratamiento
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
    }
}
