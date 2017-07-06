using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    class Paciente
    {
        AccesoBaseDatos bd;
        public Paciente()
        {
            //Se	inicializa	el	objeto	que	realiza	la	conexión	con	la	base	de	datos
            bd = new AccesoBaseDatos();
        }

        public int agregarCirugia(string cedula, string cirugia)
        {
            String insertar = "INSERT	INTO	CIRUGIAS	(CedPaciente, Cirugia)	" +
                "VALUES(" + cedula + ",'" + cirugia + "')";
            return bd.actualizarDatos(insertar);


        }

        public int agregarAntecedente(string cedula, string nombreA, string descripcion)
        {
            String insertar = "INSERT	INTO	ANT_PAT	(CedPaciente, Nombre, Descripcion)	" +
                "VALUES(" + cedula + ",'" + nombreA + "','" + descripcion + "')";
            return bd.actualizarDatos(insertar);

            
        }

        public int agregarTipoAntecedente(string nombreA, string tipo)
        {         

            String insertar = "insert into TIPO_ANT    values('" + nombreA + "','" + tipo + "');";
            return bd.actualizarDatos(insertar);
        }

        public int agregarDatoClinico(string cedula, string dato)
        {
            String insertar = "INSERT	INTO	DATOS_CLINICOS  (CedPaciente, Dato)	" +
                "VALUES(" + cedula + ",'" + dato + "')";
            return bd.actualizarDatos(insertar);
        }

        public int agregarPaciente(string cedula, string nombre, string ape1, string ape2, string fechanac, char sexo,
          string valoracion, string email, string telefono, string comentarios)
        {
            String insertar = "INSERT	INTO	PACIENTE	(Cedula, NombreP, Apellido1, Apellido2, FechaNac, Sexo,	Valoracion, Email, Telefono, Comentarios)	" +
                "VALUES(" + cedula + ",'" + nombre + "','" + ape1 + "','" + ape2 + "','" + fechanac + "','" + sexo + "','" + valoracion + "','" + email + 
                "','"  + telefono + "','" + comentarios + "')";
            return bd.actualizarDatos(insertar);
        }

        //obtenemos una lista de nombre de los pacientes
        public SqlDataReader obtenerListaNombresPacientes()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	distinct NombreP	from PACIENTE");

                                                }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        //Con este método se pueden consultar los pacientes aplicando filtros de nombre, apellido o cedula
        public DataTable obtenerPacientes(string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los pacientes de la base de datos
                if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	*	from	PACIENTE");
                }
                //Si el	filtro de nombre no	es nulo, se carga los pacientes con ese nombre en el filtro
				else if (filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	*	from	PACIENTE	where   NombreP like '%" +	filtroNombre + "%'");	

                 }
                //Si	el	filtro	general	no	es	nulo, se cargan	los	pacientes que contengan ese filtro como parte del atributo)
                else if (filtroGeneral != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	*	from	PACIENTE	where   Apellido1   like    '%" +	filtroGeneral	+	"%'   OR Apellido2   like    '%" +	filtroGeneral	+	"%'   OR  Cedula  like    '%" +	filtroGeneral	+	"%'");	

                }
                //Si ninguno de	los	filtros	es	nulo carga los pacientes que coincidan con los dos filtros
				else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	*	from	PACIENTE	where   NombreP = '" +	filtroNombre	+	"' &&   Apellido1   like    '%" 
                        +	filtroGeneral	+	"%'   OR  Apellido2   like    '%" +	filtroGeneral	+	"%'     OR  cedula  like    '%" +	filtroGeneral	+	"%'");	

                }

            }
            catch (SqlException ex)
            {

            }
            return tabla;
        }

        /*Método que elimina pacientes de acuerdo a la cédula ingresada, 
        este método realiza la ejecución usando el procedimiento almacenado eliminarPaciente*/
        public int eliminarPaciente(string cedula)
        {
            String eliminar = "EXEC eliminarPaciente '"  + cedula + "'";
            return bd.actualizarDatos(eliminar);

        }

        public string ObtenerNombre()
        {
            string nombre = "";
            return nombre;
        }
    }
}
