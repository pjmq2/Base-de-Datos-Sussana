using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class VerAntecedente : Form
    {
        //Paciente paciente;
        Antecedentes ant;
        string nombre;
        bool cambiosNombre = false;
        bool cambiosTipo = false;

        public VerAntecedente(string nombreNuevo)
        {
            InitializeComponent();
            //paciente = new Paciente();
            ant = new Antecedentes();
            nombre = nombreNuevo;
            TXT_Nombre.Text = nombre;
        }

        private void llenarTabla(DataGridView dataGridView)
        {

            DataTable tabla = ant.obtenerTipoAntecedentes(TXT_Nombre.Text);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_TipoAnte.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        #region cambio color de fondo
        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambiosNombre)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosNombre = true;
        }

        private void TXT_TipoSeleccionado_TextChanged(object sender, EventArgs e)
        {
            if (cambiosTipo)
            {
                TXT_TipoSeleccionado.BackColor = System.Drawing.Color.LightBlue;
            }
            cambiosTipo = true;
        }
        #endregion

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            bool cambioshechos = true;
            int result;
            DataGridViewRow row = DGV_TipoAnte.CurrentRow;
            string tipoViejo = row.Cells[0].Value.ToString();
            if (cambiosNombre)
            {
                result = ant.modificarNombreAntecedente(nombre, TXT_Nombre.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error. Es posible que este nombre ya exista", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }
            if (cambiosTipo)
            {
                result = ant.modificarTipoAntecedente(TXT_Nombre.Text, tipoViejo, TXT_TipoSeleccionado.Text);
                if (result != 0)
                {
                    MessageBox.Show("Ha ocurrido un error. Es posible que este tipo ya este asociado a este antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambioshechos = false;
                }
            }

            if (cambioshechos)
            {
                MessageBox.Show("¡El antecedente ha sido modificado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                VerAntecedente vp = new VerAntecedente(TXT_Nombre.Text);
                this.Dispose();
                vp.Show();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea elimar el antecedente. Esto eliminará también los tipos asociados?", "Eliminar Antecedente", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = ant.eliminarAntecedente(nombre);
                if (result == 0)
                {
                    MessageBox.Show("¡El antecedente ha sido eliminado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    BuscarAntecedentes ba = new BuscarAntecedentes();
                    this.Dispose();
                    ba.Show();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar eliminar el antecedente.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_AgregarTipo_Click(object sender, EventArgs e)
        {
            int resultado = ant.agregarTipoAntecedente(nombre, TXT_NuevoTipo.Text);

            //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
            if (resultado == 0)
            {
                MessageBox.Show("¡El tipo de antecedente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                VerAntecedente va = new VerAntecedente(nombre);
                this.Dispose();
                va.Show();
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("Ya existe este tipo asociado a este antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_EliminarTipo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea elimar el tipo de antecedente?", "Eliminar Tipo de Antecedente", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = ant.eliminarTipoAntecedente(nombre, TXT_TipoSeleccionado.Text);
                if (result == 0)
                {
                    MessageBox.Show("¡El tipo de antecedente ha sido eliminado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    VerAntecedente va = new VerAntecedente(nombre);
                    this.Dispose();
                    va.Show();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar eliminar el tipo", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VerAntecedente_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_TipoAnte);
        }

        #region Menu
        /* A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Close();
        }

        private void salirtoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Close();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Close();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Close();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Close();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Close();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Close();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Close();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Close();
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
        #endregion

        private void DGV_TipoAnte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cambiosTipo = false;
            TXT_TipoSeleccionado.BackColor = System.Drawing.Color.White;
            DataGridViewRow row = DGV_TipoAnte.CurrentRow;
            string cirugia = row.Cells[0].Value.ToString();
            TXT_TipoSeleccionado.Text = cirugia;
        }
    }
}

