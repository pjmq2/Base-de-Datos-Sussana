using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    class Antecedentes
    {
        AccesoBaseDatos bd;
        public Antecedentes()
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
        }

        public int agregarAntecedentePaciente(string cedula, string nombreA, string descripcion)
        {
            String insertar = "INSERT	INTO	HA_TENIDO	(CedulaPac, Nombre_A, Descripcion)	" +
                "VALUES('" + cedula + "','" + nombreA + "','" + descripcion + "')";
            return bd.actualizarDatos(insertar);
        }

        public int agregarAntecedente(string nombreA)
        {
            String insertar = "INSERT	INTO	ANT_PAT	(Nombre)	" +
                "VALUES('" + nombreA + "')";
            return bd.actualizarDatos(insertar);
        }

        public int agregarTipoAntecedente(string nombreA, string tipo)
        {
            String insertar = "insert into TIPO_ANT    values('" + nombreA + "','" + tipo + "');";
            return bd.actualizarDatos(insertar);
        }

        //obtenemos una lista de nombre de los antecedentes en la que no se repitan
        public SqlDataReader obtenerListaNombresAntecedentes()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	distinct Nombre from ANT_PAT");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        //obtenemos una lista de tipo de los antecedentes
        public DataTable obtenerTipoAntecedentes(string nombre)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("Select	Tipo    from TIPO_ANT    WHERE Nombre_Ant = '" + nombre + "'");
            }

            catch (SqlException ex)
            {

            }
            return tabla;
        }

        //Con este método se pueden consultar los nombres de los antecedentes creados, agrupados por nombre
        public DataTable obtenerAntecedentes(string nombre)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("Select	Nombre_Ant from	TIPO_ANT    WHERE Nombre_Ant like '" + nombre + "%'    GROUP BY Nombre_Ant");
            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        public int eliminarAntecedente(string nombre)
        {
            String eliminar = "delete from ANT_PAT where nombre = '" + nombre + "'";
            return bd.actualizarDatos(eliminar);

        }

        public int eliminarTipoAntecedente(string nombre, string tipo)
        {
            String eliminar = "delete from TIPO_ANT where Nombre_Ant = '" + nombre + "' AND Tipo = '" + tipo + "'";
            return bd.actualizarDatos(eliminar);

        }

        public int modificarTipoAntecedente(string nombre, string tipo, string tipoNuevo)
        {
            string modificacion = "update TIPO_ANT set Tipo = '" + tipoNuevo + "' where Nombre_Ant = '" + nombre + "' AND Tipo = '" + tipo + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarNombreAntecedente(string nombre, string nombreNuevo)
        {
            string modificacion = "update ANT_PAT set Nombre = '" + nombreNuevo + "' where Nombre = '" + nombre + "'";
            return bd.actualizarDatos(modificacion);
        }

    }
}
