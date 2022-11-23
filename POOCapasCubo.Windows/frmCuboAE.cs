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
    public partial class frmCuboAE : Form
    {
        public frmCuboAE()
        {
            InitializeComponent();
            ContinuoradioButton.Checked = true;
        }
        private Cubo cubo;
        private RepositorioDeCubos repo = new RepositorioDeCubos();
        private bool edicion=false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosColor();
            if (cubo != null)
            {
                edicion = true;
                AristatextBox.Text = cubo.Arista.ToString();
                ColorcomboBox.SelectedItem = (Colores)cubo.Color;
                if (cubo.Trazo == Trazo.Continuo)
                {
                    ContinuoradioButton.Checked = true;
                }
                else if (cubo.Trazo == Trazo.Rayas)
                {
                    RayasradioButton.Checked = true;
                }
                else
                {
                    PuntosradioButton.Checked = true;
                }
            }

        }
        private void CargarDatosColor()
        {
            var lista = Enum.GetValues(typeof(Colores)).Cast<Colores>().ToList();

            ColorcomboBox.DataSource = lista;
            ColorcomboBox.SelectedIndex = 0;
        }
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cubo == null)
                {
                    cubo = new Cubo();
                }
                cubo.Arista = double.Parse(AristatextBox.Text);
                cubo.Color = (Colores)ColorcomboBox.SelectedItem;
                if (ContinuoradioButton.Checked) 
                {
                    cubo.Trazo = Trazo.Continuo;
                }
                if (RayasradioButton.Checked)
                {
                    cubo.Trazo = Trazo.Rayas;
                }
                else
                {
                    cubo.Trazo = Trazo.Puntos;
                }
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            ErrorerrorProvider1.Clear();
            if(string.IsNullOrEmpty(AristatextBox.Text))
            {
                valido = false;
                ErrorerrorProvider1.SetError(AristatextBox, "Debe Ingresar un Numero");
            }
            else if (!double.TryParse(AristatextBox.Text, out double arista))
            {
                valido = false;
                ErrorerrorProvider1.SetError(AristatextBox, "Debem=n Ser solo Numeros");
            }
            return valido;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Cubo GetCubo()
        {
            return cubo;
        }

        public void SetCubo(Cubo editarcubo)
        {
            cubo = editarcubo;
        }
    }
}
