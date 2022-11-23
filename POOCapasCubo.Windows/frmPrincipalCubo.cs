using POOCapasCubo.Datos;
using POOCapasCubo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOCapasCubo.Windows
{
    public partial class frmPrincipalCubo : Form
    {
        public frmPrincipalCubo()
        {
            InitializeComponent();
        }

        private RepositorioDeCubos repo;
        private List<Cubo> lista;
        private void frmPrincipalCubo_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeCubos();
            MostrarCantidad();
            CargarColores();
            if (repo.GetCantidad() > 0)
            {
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            lista = repo.GetLista();
            MostrarLista();
        }

        private void MostrarLista()
        {
            CubosdataGridView.Rows.Clear();
            foreach (var cubo in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, cubo);
                AgregarFila(r);
            }
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            frmCuboAE frm = new frmCuboAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Cubo c = frm.GetCubo();
            repo.ArgregarCubo(c);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, c);
            AgregarFila(r);
            MostrarCantidad();

        }

        private void AgregarFila(DataGridViewRow r)
        {
            CubosdataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cubo cubo)
        {
            r.Cells[ColArista.Index].Value = cubo.Arista;
            r.Cells[ColColor.Index].Value = cubo.Color;
            r.Cells[ColTrazo.Index].Value = cubo.Trazo;
            r.Cells[ColArea.Index].Value = cubo.GetArea(cubo.Arista);
            r.Cells[ColVolumen.Index].Value = cubo.GetVolumen(cubo.Arista);

            r.Tag = cubo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(CubosdataGridView);
            return r;
        }

        private void MostrarCantidad()
        {
            ContadortextBox.Text = repo.GetCantidad().ToString();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            repo.Guardar();
            Application.Exit();
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (CubosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = CubosdataGridView.SelectedRows[0];
            Cubo borrarcubo=r.Tag as Cubo;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el cubo de Arista; {borrarcubo.Arista}?",
                "Borrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            repo.Borrar(borrarcubo);
            CubosdataGridView.Rows.Remove(r);
            MessageBox.Show("Borrado Exitoso", "Borrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (CubosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = CubosdataGridView.SelectedRows[0];
            Cubo editarcubo = r.Tag as Cubo;
            Cubo cubo= r.Tag as Cubo;
            frmCuboAE frm = new frmCuboAE() {Text= "Editar" };
            frm.SetCubo(editarcubo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            editarcubo = frm.GetCubo();
            SetearFila(r, editarcubo);
            //repo.Borrar(cubo);
            //repo.ArgregarCubo(editarcubo);
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenAscendente();
            MostrarLista();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenDescendente();
            MostrarLista();
        }
        

        private void ColorestoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var colorfiltro = (Colores)ColorestoolStripComboBox.SelectedItem;
            lista = repo.FiltrarPorColor(colorfiltro);
            MostrarLista();
            //
        }
        private void CargarColores()
        {
            var listaColores = Enum.GetValues(typeof(Colores)).Cast<Colores>().ToList();
            foreach (var col in listaColores)
            {
                ColorestoolStripComboBox.Items.Add(col);
            }
        }
    }
}
