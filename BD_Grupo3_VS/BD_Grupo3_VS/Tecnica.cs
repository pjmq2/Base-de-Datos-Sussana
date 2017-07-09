﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
{
    class Tecnica
    {
        AccesoBaseDatos bd;
        public Tecnica()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarTecnica(string nombre, int precio, string descripcion)
        {
            String insertar = "INSERT into Tecnicas (Nombre, Precio, Descripcion)" +
                 " VALUES ('" + nombre + "'," + precio + ",'" + descripcion + "')";
            return bd.actualizarDatos(insertar);
        }

        public int actualizarTecnica(string nombre)
        {
            return 1;
        }

        public DataTable consultarTecnicas(string filtroNombre)
        {
            DataTable tabla = null;

            if (filtroNombre == null)
            {
                bd.ejecutarConsultaTabla("SELECT Nombre, Precio FROM Tecnica ORDER BY Nombre");
            }
            else
            {
                bd.ejecutarConsultaTabla("SELECT Nombre, Precio FROM Tecnica WHERE Nombre LIKE '%" + filtroNombre + "%' OR DESCRIPCION LIKE '%" + filtroNombre + "%' ORDER BY Nombre");
            }

            return tabla;
        }

        public SqlDataReader obtenerListaNombres()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select distinct Nombre from Tecnica order by nombre");
            }
            catch (SqlException) { }

            return datos;
        }

        public int agregarRequerimientoDeMaterial(string nombreTecnica, string nombreMaterial, int cantidad)
        {
            String insertar = "INSERT into Requiere_De (Nombre_Tec, Nombre_Mat, Cantidad)" +
                 " VALUES ('" + nombreTecnica + "','" + nombreMaterial + "'," + cantidad + ")";
            return bd.actualizarDatos(insertar);
        }

        public int eliminarRequerimientoDeMaterial()
        {
            return 0;
        }
    }
}