using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Grupo3_VS
{
    class DatosClinicos
    {
        AccesoBaseDatos bd;
        public DatosClinicos()
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
        }
    }
}
