using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitaPlanTratamiento
{
    class Cita
    {
        AccesoBaseDatos bd;

        public Cita()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarCita(string cedula, string padecimiento, string fechaHora, int precio, string descripcion,
            decimal duracion, string lugar, string estado)
        {
            String insertar = "INSERT into CITA (CedPaciente,Padec_Act,Fecha,Precio,Descripcion,Duracion,Lugar,Estado_Paciente)" +
                " VALUES(" +cedula+ ",'" +padecimiento+ "','" +fechaHora+ "','" + precio + "','" + descripcion + "','" + duracion + "','" + lugar + "','" + estado + "')";
            return bd.actualizarDatos(insertar);
        }
    }
}
