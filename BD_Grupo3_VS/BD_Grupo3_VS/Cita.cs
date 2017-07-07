using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
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

        public DataTable consultarCitas(string cedula,string fecha)
        {
            DataTable tabla = null;
            try
            {
                if(cedula == null && fecha == null)
                {
                    tabla = bd.ejecutarConsultaTabla("exec consultaTodasCitas");
                }
                if(cedula != null && fecha == null)
                {
                    tabla = bd.ejecutarConsultaTabla("SELECT C.CedPaciente,NombreP,Apellido1,Apellido2,C.Padec_Act,C.Fecha,Precio,Descripcion,Duracion,Lugar,Estado_Paciente " +
                        "FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente join Paciente A ON A.Cedula = P.CedPaciente WHERE C.CedPaciente LIKE'%" + cedula + "%'");
                }
                if(cedula == null && fecha != null)
                {
                    tabla = bd.ejecutarConsultaTabla("SELECT C.CedPaciente,A.NombreP,A.Apellido1,A.Apellido2,C.Padec_Act,C.Fecha,C.Precio,C.Descripcion,C.Duracion,C.Lugar,C.Estado_Paciente " +
                        "FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente join Paciente A ON A.Cedula = P.CedPaciente WHERE C.Fecha LIKE '%" + fecha + "%'");
                }
                if(cedula != null && fecha != null)
                {
                    tabla = bd.ejecutarConsultaTabla("SELECT C.CedPaciente,A.NombreP,A.Apellido1,A.Apellido2,C.Padec_Act,C.Fecha,C.Precio,C.Descripcion,C.Duracion,C.Lugar,C.Estado_Paciente " +
                        "FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente join Paciente A ON A.Cedula = P.CedPaciente WHERE C.Fecha LIKE '%" + fecha + "%' OR C.CedPaciente LIKE '%" + cedula + "%'");
                }
            }catch(SqlException ex)
            {

            }
            return tabla;
        }
        public int eliminarCita(string cedula, string fecha)
        {
            String eliminar = "EXEC eliminarCita '" + cedula + "', '" + fecha + "'";
            return bd.actualizarDatos(eliminar);
        }

        public int modificarCita(string cedula, string padecimiento, string fechaHora, int precio, string descripcion,
            decimal duracion, string lugar, string estado)
        {
            String modificar = "EXEC ModificarCita  @cedula = '" + cedula + "', @padecimiento = '" + padecimiento + "', @fecha = '" + fechaHora + "', @precio" +
                " = '" + precio + "', @descripcion = '" + descripcion + "', @duracion = '" + duracion + "', @lugar = '" + lugar + "', @estado = '" + estado + "'";
            return bd.actualizarDatos(modificar);
        }
    }
}
