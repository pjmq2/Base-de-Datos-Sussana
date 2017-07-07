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
        public ModificarCita(string cedulaC,string padecimientoC, string precioC, string descripC, string duracionC, string lugarC, string estadoC)
        {
            InitializeComponent();
            cita = new Cita();
            TXT_Cedula.Text = cedulaC;
            TXT_Padecimiento.Text = padecimientoC;
            TXT_Precio.Text = precioC;
            TXT_Descripcion.Text = descripC;
            TXT_Duracion.Text = duracionC;
            CB_Lugar.Text = lugarC;
            TXT_Estado.Text = estadoC;

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
            int result = cita.modificarCita(TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"),
                precio, TXT_Descripcion.Text, duracion, CB_Lugar.Text, TXT_Estado.Text);
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

        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPaciente paciente = new ConsultarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void avanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                //Aun no cierra todo el programa
            }
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
