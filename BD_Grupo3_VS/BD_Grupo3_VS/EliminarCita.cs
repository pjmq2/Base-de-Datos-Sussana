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
    public partial class EliminarCita : Form
    {
        Cita cita;
        ConsultarCitas cc;

        public EliminarCita()
        {
            InitializeComponent();
            cita = new Cita();
            cc = new ConsultarCitas();

        }

        private void EliminarCita_Load(object sender, EventArgs e)
        {
            cc.llenaTabla(dgvEliminar, null, null);
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            int result = cita.eliminarCita(TXT_Cedula.Text);

            if(result == 0)
            {
                MessageBox.Show("¡La cita se ha eliminado correctamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                cc.llenaTabla(dgvEliminar, null, null);
         
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void LBL_Agregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCita agrega = new AgregarCita();
            agrega.Show();
            this.Hide();
        }

        private void LBL_Consultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarCitas consulta = new ConsultarCitas();
            consulta.Show();
            this.Hide();
        }

        private void LBL_Modificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarCita modi = new ModificarCita();
            modi.Show();
            this.Hide();
        }
    }
}
