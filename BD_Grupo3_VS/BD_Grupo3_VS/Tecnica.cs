using System;
using System.Collections.Generic;
using System.Data;
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
            String insertar = "INSERT into Tecnica (Nombre, Precio, Descripcion)" +
                 " VALUES (" + nombre + ",'" + precio + "','" + descripcion + "' )";
            return bd.actualizarDatos(insertar);
        }

        public DataTable consultarMateriales()
        {
            DataTable tabla = null;

            return tabla;
        }
    }
}
