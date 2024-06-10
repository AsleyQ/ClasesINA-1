using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Principal3 : Form
    {
        //Creamos una instancia del tipo list de tipo entero
        List<string> LProductos = new List<string>(); //Lista vacia
        List<int> LunidadesCompradas = new List<int>(); //Lista vacia
        List<double> LprecioUnitario = new List<double>(); //Lista vacia
        List<double> Ltotal = new List<double>(); //Lista vacia

        
        public Principal3()
        {
            InitializeComponent();
        }

        private void dtComprasP3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtPrecioUnitarioP3_Click(object sender, EventArgs e)
        {
            if (txtPrecioUnitarioP3.Text.Length >= 0)
            {
                double numero = 0;
                bool EsNumero = double.TryParse(txtPrecioUnitarioP3.Text, out numero);
                if (EsNumero)
                {
                    double precioUnitario = Convert.ToDouble(txtPrecioUnitarioP3.Text);
                    int unidadesCompradas = Convert.ToInt32(slideUnidadesP3.Value);
                    txtTotalP3.Text = "" + precioUnitario * unidadesCompradas;
                }
                else
                {
                    txtPrecioUnitarioP3.Focus();
                    txtPrecioUnitarioP3.Hint = "Debe ser número"; //
                    txtPrecioUnitarioP3.SelectAll();
                    txtPrecioUnitarioP3.BackColor = Color.AliceBlue;
                }
            }
        }

        private void slideUnidadesP3_Click(object sender, EventArgs e)
        {
            double precio = 0.0;
            bool precioUnitarioEsNumero = double.TryParse(txtPrecioUnitarioP3.Text, out precio);
            if (precioUnitarioEsNumero)
            {
                int precioUnitario = Convert.ToInt32(txtPrecioUnitarioP3.Text);
                int unidadesCompradas = Convert.ToInt32(slideUnidadesP3.Value);
                txtTotalP3.Text = "" + precioUnitario * unidadesCompradas;
            }
            else
            {
                txtPrecioUnitarioP3.Hint = "Debe ser número";
                txtPrecioUnitarioP3.Focus();
            }
        }

        private void btnProcesarCompraP3_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
