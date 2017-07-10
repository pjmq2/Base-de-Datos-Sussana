using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class AgregarUsuario : Form
    {
        AccesoBaseDatos bd;
        Form logi;
        public AgregarUsuario(Form log)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            logi = log;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text == "")
            {
                MessageBox.Show("El usuario no puede estar vacío.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TXT_Contraseña.Text == "")
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultado = bd.agregarUsuario(TXT_Usuario.Text, TXT_Contraseña.Text);
                if (resultado == 1)
                {
                    MessageBox.Show("¡El usuario y contraseña han sido agregados exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);                   
                    logi.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(resultado + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
