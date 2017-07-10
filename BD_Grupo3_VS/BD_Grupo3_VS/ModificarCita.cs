using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class ModificarCita : Form
    {
        Cita cita;
        public ModificarCita(string cedulaC,string padecimientoC, string precioC, string descripC, string duracionC, string lugarC, string estadoC, string fechaC)
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
            dtp_Fecha.Text = fechaC;
            TXT_CeduCambiar.Text = cedulaC;
            TXT_PadeCambiar.Text = padecimientoC;
            TXT_FechaCambiar.Text = fechaC;
            llenarComboAgregar();
            llenarComboEliminar(cedulaC, padecimientoC, fechaC);
        }


    

       

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
         
            ConsultarCitas cc = new ConsultarCitas("");
            int precio = Convert.ToInt32(TXT_Precio.Text);

            int result = cita.modificarCita(TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"),
                precio, TXT_Descripcion.Text, TXT_Duracion.Text, CB_Lugar.Text, TXT_Estado.Text,TXT_CeduCambiar.Text,TXT_PadeCambiar.Text,TXT_FechaCambiar.Text);
            if(result == 0)
            {
                MessageBox.Show("¡La cita se ha modificado con éxito!", "Results", MessageBoxButtons.OK, MessageBoxIcon.None);
                cc.Show();
                this.Hide();
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


        private void llenarComboEliminar(string cedBusq,string padeBusq,string fechaBusq)
        {
            SqlDataReader datos = cita.obtenerTecnicasPorCita(cedBusq, padeBusq, fechaBusq);
            if (datos != null)
            {
                while (datos.Read())
                {
                    CB_EliminaTecnica.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                CB_EliminaTecnica.Items.Clear();
            }

        }

        private void llenarComboAgregar()
        {
            SqlDataReader datos = cita.obtenerTodasTecnicas();
            if(datos != null)
            {
                while (datos.Read())
                {
                    CB_AgregaTecnica.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                CB_AgregaTecnica.Items.Clear();
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Dispose();
        }

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Dispose();
        }

        private void crearPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Dispose();
        }

        private void avanzadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }

        private void BTN_AgregaTecnica_Click(object sender, EventArgs e)
        {
            int result = cita.agregarTecnicaCita(TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"), CB_AgregaTecnica.Text);

            if(result == 0)
            {
                MessageBox.Show("¡La técnica ha sido agregada a la cita!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            else if(result == 2627)
            {
                MessageBox.Show("Esta técnica ya ha sido asignada previamente a esta cita", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarTecnica_Click(object sender, EventArgs e)
        {
            int result = cita.eliminarTecnicaCita(TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"), CB_EliminaTecnica.Text);
            if (result == 0)
            {
                llenarComboEliminar(TXT_Cedula.Text, TXT_Padecimiento.Text, dtp_Fecha.Value.ToString("dd/MM/yyyy HH:mm"));
                MessageBox.Show("¡La técnica ha sido eliminada de la cita!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
               
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LINK_Atras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarCitas cc = new ConsultarCitas("");
            cc.Show();
            this.Dispose();

        }
    }
}
