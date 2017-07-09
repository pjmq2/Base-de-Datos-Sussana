using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    class Cirugias
    {
        AccesoBaseDatos bd;
        string cedula;
        public Cirugias(string cedulaNueva)
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
            cedula = cedulaNueva;
        }

        public int modificarCirugia(string cedula, string cirugia, string cirugiaNuevo)
        {
            string modificacion = "update CIRUGIAS set Cirugia = '" + cirugiaNuevo + "' where CedPaciente = '" + cedula + "' AND Cirugia = '" + cirugia + "'";
            return bd.actualizarDatos(modificacion);
        }

        //Con este método se pueden consultar las cirugías pertenecientes a un paciente
        public DataTable obtenerCirugias(string cedula)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("Select	Cirugia from	CIRUGIAS    WHERE CedPaciente = '" + cedula + "'");
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        public int agregarCirugia(string cedula, string cirugia)
        {
            String insertar = "INSERT	INTO	CIRUGIAS	(CedPaciente, Cirugia)	" +
                "VALUES(" + cedula + ",'" + cirugia + "')";
            return bd.actualizarDatos(insertar);
        }

        public int eliminarCirugia(string cedula, string nombre)
        {
            String eliminar = "delete from CIRUGIAS where CedPaciente = '" + cedula + "' AND Cirugia = '" + nombre + "'";
            return bd.actualizarDatos(eliminar);

        }
    }
}
