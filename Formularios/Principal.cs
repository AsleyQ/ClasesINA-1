using MaterialSkin.Controls;
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

    public partial class Principal : MaterialForm
    {
        string[] Vproductos = { }; //declaramos el vector para productos (que esté vacío)  (V de vector)
        int[] VUnidadesCompradas = { }; //vector para unidades compradas
        double[] VprecioUnitario = { }; //vector para el precio unitario
        double[]Vtotal = { };//vector para el total generado por la línea de compra
        
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            /*int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;*/
            if  (txtPrecioUnitario.Text.Length >= 0){
                double numero = 0;
                bool EsNumero = double.TryParse(txtPrecioUnitario.Text, out numero);
                if (EsNumero)
                {
                    double precioUnitario = Convert.ToDouble (txtPrecioUnitario.Text);
                    int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
                    txtTotal.Text = "" + precioUnitario * unidadesCompradas;
                }
                else {
                    txtPrecioUnitario.Focus();
                    txtPrecioUnitario.Hint = "Debe ser número"; //
                    txtPrecioUnitario.SelectAll();
                    txtPrecioUnitario.BackColor = Color.AliceBlue;
                }
            }
        }

        private void slideUnidades_onValueChanged(object sender, int newValue)
        {
            double precio = 0.0;
            bool precioUnitarioEsNumero = double.TryParse(txtPrecioUnitario.Text,out precio);
            if (precioUnitarioEsNumero)
            {
                int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
                int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
                txtTotal.Text = "" + precioUnitario * unidadesCompradas;
            }
            else
            {
                txtPrecioUnitario.Hint = "Debe ser número";
                txtPrecioUnitario.Focus();
            }
            
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            double precio = 0.0;

            //conversión del tipo cadena a int
            int unidades = (int)slideUnidades.Value;
            bool precioEsValido = double.TryParse(txtPrecioUnitario.Text, out precio);
            double total = double.Parse(txtTotal.Text);

            string nombreProducto = txtProducto.Text;

            if (total <= 0 || unidades <= 0 || !precioEsValido)
            {
                MessageBox.Show("Los valores no pueden ser cero o valores negativos");
            }
            else
            {
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    MessageBox.Show("El nombre del producto no debe ser vacío");
                }
                else
                {//acá, entonces empezamos a realizar la inserción
                 //Ahora vamos a redimensionar los vectores

                    double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);


                    Array.Resize(ref Vproductos, Vproductos.Length + 1);
                    Array.Resize(ref VUnidadesCompradas, VUnidadesCompradas.Length + 1);
                    Array.Resize(ref VprecioUnitario, VprecioUnitario.Length + 1);
                    Array.Resize(ref Vtotal, Vtotal.Length + 1);
                    //ya que hicimos espacio, vamos a guardar en ese espacio, los valores calculados
                    Vproductos[Vproductos.Length - 1] = nombreProducto;
                    VUnidadesCompradas[VUnidadesCompradas.Length - 1] = unidades;
                    VprecioUnitario[VprecioUnitario.Length - 1] = precioUnitario;
                    Vtotal[Vtotal.Length - 1] = total;
                    //acá únicamente empezamos a limpiar los datos del formulario para poder registrar otro producto
                    txtPrecioUnitario.Text = "";
                    txtProducto.Text = "";
                    txtTotal.Text = "0.0";
                    slideUnidades.Value = 0;//volvemos a hacer que el slide tenga como valor el 0
                    MessageBox.Show("Compra efectuada con éxito");
                    txtProducto.Focus();//para poner el foco dentro del primer campo de texto

                    dtCompras.Rows.Clear();

                    for (int i = 0; i < Vproductos.Length; i++)
                    {
                        dtCompras.Rows.Add(Vproductos[i], VprecioUnitario[i], VUnidadesCompradas[i], Vtotal[i]);
                    }

                }
            }



        }
    }
}
