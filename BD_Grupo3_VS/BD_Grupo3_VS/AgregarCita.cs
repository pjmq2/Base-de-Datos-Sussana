using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class AgregarCita : Form
    {
        Cita cita;
        public AgregarCita(string cedBusq)
        {
            InitializeComponent();
            cita = new Cita();
            TXT_Cedula.Text = cedBusq;
            llenarComboBox(cedBusq);
            TXT_Precio.Text = "0";
        }

        private void llenarComboBox(string cedBusq)
        {
            SqlDataReader datos = cita.obtieneTratamientos(cedBusq);
            if(datos != null)
            {
                while (datos.Read())
                {
                    CB_Padecimiento.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                CB_Padecimiento.Items.Clear();
            }
            
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int precioAg = Convert.ToInt32(TXT_Precio.Text);
     

            int result = cita.agregarCita(TXT_Cedula.Text, CB_Padecimiento.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm"), precioAg, TXT_Descripcion.Text,
             TXT_Duracion.Text, CB_Lugar.Text,TXT_Estado.Text);
            
            if (result == 0)
            {
                MessageBox.Show("¡La cita ha sido agregada correctamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Cedula.Clear();
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
                else if(result == 547)
                {
                    MessageBox.Show("Ha ocurrido un error, verifique que ´la duración esté en el rango de 1.0 a 4.0 y que los campos obligatorios hayan sido llenados.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar agregar la cita. Puede intentar lo siguiente:\n \n -Verifique que" +
                        " el número de cédula corresponda al de algún paciente registrado en el sistema \n -Verifique que el padecimiento concuerde con el de " +
                        "algún plan de tratamiento asociado al paciente \n -Verifique su conexión a la base de datos.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarCita_Load(object sender, EventArgs e)
        {

        }

       

      



        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
       

      

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

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Dispose();
        }

        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
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

        private void BTN_Lista_Click(object sender, EventArgs e)
        {
            ConsultarCitas cc = new ConsultarCitas(TXT_Cedula.Text);
            cc.Show();
            this.Dispose();
        }


    }
}
