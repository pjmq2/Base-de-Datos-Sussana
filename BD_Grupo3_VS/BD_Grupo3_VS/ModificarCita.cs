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
    public partial class ModificarCita : Form
    {
        Cita cita;
        public ModificarCita()
        {
            InitializeComponent();
            cita = new Cita();
        }

        private void LINK_AgregarCita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCita a = new AgregarCita();
            a.Show();
            this.Hide();
        }

        private void LINK_Consultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarCitas c = new ConsultarCitas();
            c.Show();
            this.Hide();
         
        }

        private void LINK_Eliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarCita ec = new EliminarCita();
            ec.Show();
            this.Hide();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(TXT_Precio.Text);
            decimal duracion = Convert.ToDecimal(TXT_Duracion.Text);
            int result = cita.modificarCita(TXT_CeduModificar.Text, TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"),
                precio, TXT_Descripcion.Text, duracion, CB_Lugar.Text, TXT_Estado.Text,DTP_FechaAnt.Value.ToString("dd/MM/yyyy HH:mm"));
            if(result == 0)
            {
                MessageBox.Show("¡La cita se ha modificado con éxito!", "Results", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar modificar la cita", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarCita_Load(object sender, EventArgs e)
        {

        }
    }
}
