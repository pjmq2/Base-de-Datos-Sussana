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
    public partial class AgregarCita : Form
    {
        Cita cita;
        public AgregarCita()
        {
            InitializeComponent();
            cita = new Cita();
        }

        private void CB_Lugar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int precioAg = Convert.ToInt32(TXT_Precio.Text);
            decimal duracionAg = Convert.ToDecimal(TXT_Duracion.Text);
     

            int result = cita.agregarCita(TXT_Cedula.Text, TXT_Padecimiento.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm"), precioAg, TXT_Descripcion.Text,
             duracionAg, CB_Lugar.Text,TXT_Estado.Text);
            
            if (result == 0)
            {
                MessageBox.Show("¡La cita ha sido agregada correctamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Cedula.Clear();
                TXT_Padecimiento.Clear();
                TXT_Estado.Clear();
                TXT_Precio.Clear();
                TXT_Descripcion.Clear();
                TXT_Duracion.Clear();
            }
            else
            {
                if (result == 2627)
                {
                    MessageBox.Show("Ya existe esta cita para este paciente en esta fecha", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar agregar la cita. Puede intentar lo siguiente:\n \n \n -Verifique que" +
                        " el número de cédula corresponda al de algún paciente registrado en el sistema \n -Verifique que el padecimiento concuerde con el de " +
                        "algún plan de tratamiento asociado al paciente", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarCita_Load(object sender, EventArgs e)
        {

        }

        private void LINK_ConsultarCita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarCitas consulta = new ConsultarCitas();
            consulta.Show();
            this.Hide();
        }

      



        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
       

      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void crearPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void avanzadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void BTN_Lista_Click(object sender, EventArgs e)
        {
            ConsultarCitas cc = new ConsultarCitas();
            cc.Show();
            this.Hide();
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
