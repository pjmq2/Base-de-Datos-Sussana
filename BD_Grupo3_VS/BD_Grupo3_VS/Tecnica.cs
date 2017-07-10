using System;
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
            String insertar = "INSERT into Tecnica (Nombre, Descripcion, Precio)" +
                 " VALUES ('" + nombre + "','" + descripcion + "'," + precio + ")";
            return bd.actualizarDatos(insertar);
        }

        public DataTable consultarTecnicas(string filtro)
        {
            DataTable tabla = null;

            if (filtro == null)
            {
                tabla = bd.ejecutarConsultaTabla("SELECT Nombre, Precio FROM Tecnica ORDER BY Nombre");
            }
            else
            {
                tabla = bd.ejecutarConsultaTabla("SELECT Nombre, Precio FROM Tecnica WHERE Nombre LIKE '%" + filtro + "%' OR DESCRIPCION LIKE '%" + filtro + "%' ORDER BY Nombre");
            }

            return tabla;
        }

        public string consultarDescripcion(string nombre)
        {
            string descripcion = null;
            SqlDataReader datos;
            datos = bd.ejecutarConsulta("SELECT Descripcion FROM Tecnica WHERE Nombre = '" + nombre + "'");
            if (datos.Read())
            {
                descripcion = datos.GetString(0);
            }

            return descripcion;
        }

        public int actualizarTecnica(string nombre, string nuevoNombre, string nuevaDescripcion, int nuevoPrecio)
        {
            int result;
            string update = "update TECNICA set Nombre = '" + nuevoNombre +
                "', Descripcion = '" + nuevaDescripcion +
                "', Precio = " + nuevoPrecio +
                " where Nombre = '" + nombre + "'";
            result = bd.actualizarDatos(update);
            return result;
        }

        public int eliminarTecnica(string nombre)
        {
            int result = bd.eliminarTecnica(nombre);
            return result;
        }

        public SqlDataReader obtenerListaNombres()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select Nombre from Tecnica order by nombre");
            }
            catch (SqlException) { }

            return datos;
        }

        public SqlDataReader obtenerListaMaterialesRequeridos(string nombreTec)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("Select Nombre_Mat from Requiere_De Where Nombre_Tec = '" + nombreTec +
                    "' order by Nombre_Mat");
            }
            catch (SqlException) { }
            return datos;
        }

        public SqlDataReader obtenerListaMaterialesNoRequeridos(string nombreTec)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("SELECT Nombre From Material EXCEPT SELECT M.Nombre FROM Requiere_De RD JOIN Material M ON RD.Nombre_Mat = M.Nombre JOIN Tecnica T ON RD.Nombre_Tec = '" + nombreTec + "'");
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

        public int actualizarRequerimientoDeMaterial(string nombreTecnica, string nombreMaterial, int cantidad)
        {
            int result;
            string update = "update Requiere_De set Cantidad = " + cantidad +
                " where Nombre_Tec = '" + nombreTecnica + "' AND Nombre_Mat = '" + nombreMaterial + "'";
            result = bd.actualizarDatos(update);
            return result;
        }

        public int eliminarRequerimientoDeMaterial(string nombreTecnica, string nombreMaterial)
        {
            int result = bd.eliminarRequiereDe(nombreTecnica, nombreMaterial);
            return result;
        }

        public int consultarCantidad(string nombreTec, string nombreMat)
        {
            int cantidad = 0;
            SqlDataReader datos;
            datos = bd.ejecutarConsulta("SELECT Cantidad FROM Requiere_De WHERE Nombre_Tec = '" + nombreTec + "' AND Nombre_Mat = '" + nombreMat + "'");
            if (datos.Read())
            {
                cantidad = datos.GetInt32(0);
            }
            
            return cantidad;
        }
    }
}