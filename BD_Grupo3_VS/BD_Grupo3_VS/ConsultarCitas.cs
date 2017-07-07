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
    public partial class ConsultarCitas : Form
    {
        Cita cita;
        
        public ConsultarCitas()
        {
            InitializeComponent();
            cita = new Cita();
        }

        private void ConsultarCitas_Load(object sender, EventArgs e)
        {
           llenaTabla(dgv1,null,null);
        }
        public void llenaTabla(DataGridView dgv, string porCedula, string porFecha)
        {
            DataTable tabla = cita.consultarCitas(porCedula, porFecha);
            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgv.DataSource = bs;
            for(int i = 0; i<dgv1.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 110;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if(TXT_Cedula.Text != "" && TXT_Fecha.Text != "")
            {
                llenaTabla(dgv1, TXT_Cedula.Text, TXT_Fecha.Text);
            }
            if(TXT_Cedula.Text != "" && TXT_Fecha.Text == "")
            {
                llenaTabla(dgv1, TXT_Cedula.Text, null);
            }
            if(TXT_Cedula.Text == "" && TXT_Fecha.Text != "")
            {
                llenaTabla(dgv1, null, TXT_Fecha.Text);
            }
            if(TXT_Cedula.Text == "" && TXT_Fecha.Text == "")
            {
                llenaTabla(dgv1, null, null);
            }
            TXT_Cedula.Clear();

        }

        private void LINK_Agregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCita agrega = new AgregarCita();
            agrega.Show();
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

        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
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

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            string cedulaC, padecimientoC, precioC, descripC, duracionC, lugarC, estadoC,fechaC; 



            DataGridViewRow row = dgv1.CurrentRow;
            cedulaC = row.Cells[0].Value.ToString();
            padecimientoC = row.Cells[4].Value.ToString();
            fechaC = row.Cells[5].Value.ToString();
            precioC = row.Cells[6].Value.ToString();
            descripC = row.Cells[7].Value.ToString();
            duracionC = row.Cells[8].Value.ToString();
            lugarC = row.Cells[9].Value.ToString();
            estadoC = row.Cells[10].Value.ToString();
            ModificarCita mc = new ModificarCita(cedulaC,padecimientoC,precioC,descripC,duracionC,lugarC,estadoC,fechaC);
            mc.Show();
            this.Hide();
            
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            int result;
            string cedulaEliminar, fechaEliminar;
            DataGridViewRow re = dgv1.CurrentRow;
            cedulaEliminar = re.Cells[0].Value.ToString();
            fechaEliminar = re.Cells[5].Value.ToString();
            result = cita.eliminarCita(cedulaEliminar, fechaEliminar);
            if(result == 0)
            {
                MessageBox.Show("¡Se ha eliminado la cita!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.None);
                llenaTabla(dgv1, null, null);
            }
            else
            {
                if(result == 1)
                {

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error eliminando la cita", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
