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
        }

        private void LINK_Agregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCita agrega = new AgregarCita();
            agrega.Show();
            this.Hide();
        }

        private void LINK_Eliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarCita elimina = new EliminarCita();
            elimina.Show();
            this.Hide();
        }

        private void LINK_Modificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModificarCita mc = new ModificarCita();
            mc.Show();
            this.Hide();
        }
    }
}
