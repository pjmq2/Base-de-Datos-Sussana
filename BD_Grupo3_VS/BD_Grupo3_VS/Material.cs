﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
{
    class Material
    {
        AccesoBaseDatos bd;
        public Material()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarMaterial(string nombre, int precio)
        {
            String insertar = "INSERT into MATERIAL (Nombre, Precio)" +
                 " VALUES ('" + nombre + "'," + precio + ")";
            return bd.actualizarDatos(insertar);
        }

        public DataTable consultarMateriales(string filtroNombre)
        {
            DataTable tabla = null;

            if(filtroNombre == null)
            {
                tabla = bd.ejecutarConsultaTabla("SELECT * FROM Material");
            } else
            {
                tabla = bd.ejecutarConsultaTabla("SELECT * FROM Material WHERE Nombre LIKE '%" + filtroNombre + "%'");
            }

            return tabla;
        }

        public int actualizarMaterial(string nombre, string nuevoNombre, int nuevoPrecio)
        {
            int result;
            string update = "update Material set Nombre = '" + nuevoNombre +
                "', Precio = " + nuevoPrecio +
                " where Nombre = '" + nombre + "'";
            result = bd.actualizarDatos(update);
            return result;
        }

        public int eliminarMaterial(string nombre)
        {
            int result = bd.eliminarMaterial(nombre);
            return result;
        }

        public SqlDataReader obtenerListaNombres()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select distinct Nombre from Material order by nombre");
            }
            catch (SqlException) { }

            return datos;
        }
    }
}