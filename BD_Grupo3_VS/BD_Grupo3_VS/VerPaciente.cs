using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    public partial class VerPaciente : Form
    {
        Paciente paciente;
        bool cambios1 = false;
        bool cambios2 = false;
        bool cambios3 = false;
        bool cambios4 = false;
        bool cambios5 = false;
        bool cambios6 = false;
        bool cambios7 = false;
        bool cambios8 = false;
        bool cambios9 = false;
        bool cambios10 = false;
        string nombre;
        string apellido1;
        string apellido2;
        string cedula;
        public VerPaciente(string cedulaNueva, string nombreNuevo, string apellido1Nuevo, string apellido2Nuevo)
        {
            InitializeComponent();
            paciente = new Paciente();
            nombre = nombreNuevo;
            apellido1 = apellido1Nuevo;
            apellido2 = apellido2Nuevo;
            cedula = cedulaNueva;
            TXT_Nombre.Text = nombre;
            TXT_Apellido1.Text = apellido1;
            TXT_Apellido2.Text = apellido2;
            TXT_Cedula.Text = cedula;
        }

        private void VerPaciente_Load(object sender, EventArgs e)
        {
            SqlDataReader dato = paciente.obtenerTelefono(TXT_Cedula.Text);
            dato.Read();
            TXT_Telefono.Text = dato.GetString(0);

            dato = paciente.obtenerEmail(TXT_Cedula.Text);
            dato.Read();
            TXT_Email.Text = dato.GetString(0);

            dato = paciente.obtenerSexo(TXT_Cedula.Text);
            dato.Read();
            TXT_Sexo.Text = dato.GetString(0);

            dato = paciente.obtenerValoracion(TXT_Cedula.Text);
            dato.Read();
            TXT_Valoracion.Text = dato.GetString(0);

            dato = paciente.obtenerComentarios(TXT_Cedula.Text);
            dato.Read();
            TXT_Comentarios.Text = dato.GetString(0);

            dato = paciente.obtenerFechaNac(TXT_Cedula.Text);
            dato.Read();
            DTP_FechaNac.Value = dato.GetDateTime(0);

        }


        private void Inicio()
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

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            paciente.eliminarPaciente(cedula);
            MessageBox.Show("¡El paciente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambios1)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios1 = true;
        }

        private void TXT_Apellido1_TextChanged(object sender, EventArgs e)
        {           
            if (cambios2)
            {
                TXT_Apellido1.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios2 = true;
        }

        private void TXT_Apellido2_TextChanged(object sender, EventArgs e)
        {           
            if (cambios3)
            {
                TXT_Apellido2.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios3 = true;
        }

        private void TXT_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (cambios4)
            {
                TXT_Cedula.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios4 = true;
        }

        private void TXT_Sexo_TextChanged(object sender, EventArgs e)
        {
            if (cambios5)
            {
                TXT_Sexo.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios5 = true;
        }

        private void TXT_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (cambios6)
            {
                TXT_Telefono.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios6 = true;
        }

        private void TXT_Email_TextChanged(object sender, EventArgs e)
        {
            if (cambios7)
            {
                TXT_Email.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios7 = true;
        }

        private void DTP_FechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (cambios8)
            {
                DTP_FechaNac.CalendarForeColor = System.Drawing.Color.LightBlue;
            }
            cambios8 = true;
        }

        private void TXT_Valoracion_TextChanged(object sender, EventArgs e)
        {
            if (cambios9)
            {
                TXT_Valoracion.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios9 = true;
        }

        private void TXT_Comentarios_TextChanged(object sender, EventArgs e)
        {
            if (cambios10)
            {
                TXT_Comentarios.BackColor = System.Drawing.Color.LightBlue;
            }
                cambios10 = true;           
        }
    }
}
