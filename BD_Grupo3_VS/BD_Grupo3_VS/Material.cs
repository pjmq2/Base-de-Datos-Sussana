﻿using System;
using System.Collections.Generic;
using System.Data;
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
                 " VALUES (" + nombre + ",'" + precio + "')";
            return bd.actualizarDatos(insertar);
        }

        public DataTable consultarMateriales()
        {
            DataTable tabla = null;

            return tabla;
        } 
    }
}