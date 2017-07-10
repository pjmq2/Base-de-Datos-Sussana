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
    public partial class AgregarAntecedentes : Form
    {
        
        Antecedentes antecedente;
        public AgregarAntecedentes()
        {
            InitializeComponent();
            antecedente = new Antecedentes();
            
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int resultado = antecedente.agregarAntecedente(TXT_NombreAnte.Text);

            //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
            if (resultado == 0)
            {               
                //insertamos el tipo de antecedente
                int resultado2 = antecedente.agregarTipoAntecedente(TXT_NombreAnte.Text, TXT_TipoAnt.Text);
                //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
                if (resultado2 == 0)
                {
                    MessageBox.Show("¡El antecedente y su tipo de antecedente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);                   
                    TXT_NombreAnte.Clear();
                    TXT_TipoAnt.Clear();
                }
                else
                {
                    if (resultado2 == 2627)
                    {
                        MessageBox.Show("Ya existe este tipo de antecedente asociado al nombre del antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(resultado2 + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("Ya existe este antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(" Ha ocurrido un error al intentar agregar el antecendente. \n -Recuerde que los Nombre y Tipo " +
                        "no pueden estar vacíos.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        #region Menu
        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Dispose();
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Dispose();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Dispose();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Dispose();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Dispose();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Dispose();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Dispose();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Dispose();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Dispose();
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
        #endregion
    }
}

