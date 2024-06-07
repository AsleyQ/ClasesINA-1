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
        double[] VprecioUnitario = { }; //vector para el total generado por la línea de compra 
        double[]Vtotal = { };
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;
        }

        private void slideUnidades_onValueChanged(object sender, int newValue)
        {
            int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtProducto.Text;
            int unidades = Convert.ToInt32(slideUnidades.Value);
            double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
            double Total = Convert.ToDouble(txtTotal.Text); 

            //Ahora vamos a redimensionar los vectores
            if (Total<= 0 || unidades <=0) {
                MessageBox.Show("Los valores no pueden ser cero");
            }
            else { 
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    MessageBox.Show("El nombre del producto no debe ser vacío");
                }
                else{//Acá, entonces empezamos a realizar la inserción
                    //Ahora vamos a redimencionar los vectores
                    Array.Resize(ref Vproductos,Vproductos.Length+1);
                    Array.Resize(ref VUnidadesCompradas, VUnidadesCompradas.Length + 1);
                    Array.Resize(ref VprecioUnitario, VprecioUnitario.Length + 1);
                    Array.Resize(ref Vtotal, Vtotal.Length+1);
                    //ya que hicimos espacio, vamos a guardar en ese espacio, los valores calculados
                    Vproductos[Vproductos.Length - 1] = nombreProducto;
                    VUnidadesCompradas[Vproductos.Length - 1] = unidades;
                    VprecioUnitario[VprecioUnitario.Length -1] = precioUnitario;
                    Vtotal[Vtotal.Length - 1] = Total;
                    //Acá únicamente empezamos a limpiar los datos del formulario para poder registrar
                    txtPrecioUnitario.Text = "";
                    txtProducto.Text = "";
                    txtTotal.Text = "0.0";
                    slideUnidades.Value = 0; //volvemos a hacer que el slide tenga como valor el 0
                    MessageBox.Show("Compra efectuada con éxito");
                    txtProducto.Focus(); //para poner el foco dentro del primer campo de texto.


                }
            }
        }
    }
}
