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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.TXT_Usuario.Text) && !string.IsNullOrWhiteSpace(this.TXT_Password.Text))
            {
                BTN_Aceptar.Enabled = true;
            } else
            {
                BTN_Aceptar.Enabled = false;
            }
        }

        private void TXT_Password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.TXT_Usuario.Text) && !string.IsNullOrWhiteSpace(this.TXT_Password.Text))
            {
                BTN_Aceptar.Enabled = true;
            }
            else
            {
                BTN_Aceptar.Enabled = false;
            }
        }
    }
}
