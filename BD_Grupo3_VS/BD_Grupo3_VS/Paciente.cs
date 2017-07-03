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

        /*Método	para	agregar	un	nuevo	paciente	a	la	base	de	datos
        public int agregarPaciente(string cedula, string nombre, string ape1, string ape2, int edad, char sexo,
          string valoracion, string email, int telefono, string comentarios)
        {
            String insertar = "INSERT	INTO	PACIENTE	(Cedula, NombreP, Apellido1, Apellido2, Edad, Sexo,	Valoracion, Email, Numero, Comentarios)	" +
                "VALUES(" + cedula + ",'" + nombre + "','" + ape1 + "','" + ape2 + "','" + edad + "','" + sexo + "','" + valoracion + "','" + email + 
                "','"  + telefono + "','" + comentarios + "')";
            return bd.actualizarDatos(insertar);
        }
        */
        
    }
}
