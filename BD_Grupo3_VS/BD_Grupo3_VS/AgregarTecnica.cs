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
    public partial class AgregarTecnica : Form
    {
        Tecnica tecnica;

        public AgregarTecnica()
        {
            InitializeComponent();
            tecnica = new Tecnica();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int result = tecnica.agregarTecnica(txt_nombre.Text, (int)nud_precio.Value, txt_descripcion.Text);
        }

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_consultarTecnicas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarTecnicas consultar = new ConsultarTecnicas();
            consultar.Show();
            this.Hide();
        }
    }
}
