﻿using System;
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

        #region Métodos de modificar

        public int modificarCedula(string cedula, string cedulaNuevo)
        {
            string modificacion = "update PACIENTE set Cedula = '" + cedulaNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarNombre(string cedula, string nombreNuevo)
        {
            string modificacion = "update PACIENTE set NombreP = '" + nombreNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarApellido1(string cedula, string ape1Nuevo)
        {
            string modificacion = "update PACIENTE set Apellido1 = '" + ape1Nuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarApellido2(string cedula, string ape2Nuevo)
        {
            string modificacion = "update PACIENTE set Apellido2 = '" + ape2Nuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarEmail(string cedula, string emailNuevo)
        {
            string modificacion = "update PACIENTE set Email = '" + emailNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarTelefono(string cedula, string telefonoNuevo)
        {
            string modificacion = "update PACIENTE set Telefono = '" + telefonoNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarFechaNac(string cedula, string fechaNuevo)
        {
            string modificacion = "update PACIENTE set FechaNac = '" + fechaNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarValoracion(string cedula, string valoracionNuevo)
        {
            string modificacion = "update PACIENTE set Valoracion = '" + valoracionNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarComentarios(string cedula, string comentariosNuevo)
        {
            string modificacion = "update PACIENTE set Comentarios = '" + comentariosNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarSexo(string cedula, string sexoNuevo)
        {
            string modificacion = "update PACIENTE set Sexo = '" + sexoNuevo + "' where Cedula = '" + cedula + "'";
            return bd.actualizarDatos(modificacion);
        }

        public int modificarCirugia(string cedula, string cirugia, string cirugiaNuevo)
        {
            string modificacion = "update CIRUGIAS set Cirugia = '" + cirugiaNuevo + "' where CedPaciente = '" + cedula + "' AND Cirugia = '" + cirugia + "'";
            return bd.actualizarDatos(modificacion);
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

        #endregion

        #region Métodos para obtener valores
        public SqlDataReader obtenerComentarios(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	Comentarios from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        public SqlDataReader obtenerValoracion(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	Valoracion	from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        public SqlDataReader obtenerTelefono(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	Telefono	from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        public SqlDataReader obtenerFechaNac(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	FechaNac	from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        public SqlDataReader obtenerEmail(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	Email	from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        public SqlDataReader obtenerSexo(string cedula)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select	Sexo	from PACIENTE   where Cedula = '" + cedula + "'");

            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        //obtenemos una lista de nombre de los pacientes en la que no se repitan
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

        //Con este método se obtiene la cédula y nombre completo de los pacientes, también se puedan usar filtros
        public DataTable obtenerPacientes(string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los pacientes de la base de datos
                if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	Cedula, NombreP, Apellido1, Apellido2	from	PACIENTE");
                }
                //Si el	filtro de nombre no	es nulo, se carga los pacientes con ese nombre en el filtro
                else if (filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	Cedula, NombreP, Apellido1, Apellido2	from	PACIENTE	where   NombreP like '%" + filtroNombre + "%'");

                }
                //Si	el	filtro	general	no	es	nulo, se cargan	los	pacientes que contengan ese filtro como parte del atributo)
                else if (filtroGeneral != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	Cedula, NombreP, Apellido1, Apellido2	from	PACIENTE	where   Apellido1   like    '%" + filtroGeneral + "%'   OR Apellido2   like    '%" + filtroGeneral + "%'   OR  Cedula  like    '%" + filtroGeneral + "%'");

                }
                //Si ninguno de	los	filtros	es	nulo carga los pacientes que coincidan con los dos filtros
                else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select	Cedula, NombreP, Apellido1, Apellido2	from	PACIENTE	where   NombreP = '" + filtroNombre + "' &&   Apellido1   like    '%"
                        + filtroGeneral + "%'   OR  Apellido2   like    '%" + filtroGeneral + "%'     OR  cedula  like    '%" + filtroGeneral + "%'");

                }

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

        #endregion

        #region Métodos para insertar

        public int agregarCirugia(string cedula, string cirugia)
        {
            String insertar = "INSERT	INTO	CIRUGIAS	(CedPaciente, Cirugia)	" +
                "VALUES(" + cedula + ",'" + cirugia + "')";
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
        #endregion

        #region Métodos para eliminar
        /*Método que elimina pacientes de acuerdo a la cédula ingresada, 
        este método realiza la ejecución usando el procedimiento almacenado eliminarPaciente*/
        public int eliminarPaciente(string cedula)
        {
            String eliminar = "EXEC eliminarPaciente '"  + cedula + "'";
            return bd.actualizarDatos(eliminar);

        }

        public int eliminarCirugia(string cedula, string nombre)
        {
            String eliminar = "delete from CIRUGIAS where CedPaciente = '" + cedula + "' AND Cirugia = '" + nombre + "'";
            return bd.actualizarDatos(eliminar);

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
        #endregion
    }
}
