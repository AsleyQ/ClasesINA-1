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
        List<string> LProductos = new List<string> {"blusa Aero"}; //Lista con una valor predefinido
        List<int> LunidadesCompradas = new List<int> {2}; //Lista vacia
        List<double> LprecioUnitario = new List<double> {10000}; //Lista vacia
        List<double> Ltotal = new List<double> {20000}; //Lista vacia

        string nombreProductoEliminar = "";

        public Principal3()
        {
            InitializeComponent();
        }

        private void Principal3_Load(object sender, EventArgs e)
        {
            ImprimirCompras();
        }
        /// <summary>
        /// Imprime la información de la lista dentro del DataGridView
        /// </summary>

        private void ImprimirCompras()
        {
            dtComprasP3.Rows.Clear();
            for (int i = 0; i < LProductos.Count; i++)
            {
                if (!string.IsNullOrEmpty(LProductos[i]))
                {
                    dtComprasP3.Rows.Add(LProductos[i], LprecioUnitario[i], LunidadesCompradas[i], Ltotal[i]);
                }
            }
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
                    txtPrecioUnitarioP3.Hint = "Debe ser número"; 
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
            double precio = 0.0; 
           

            //conversión del tipo cadena a int
            int unidades = (int)slideUnidadesP3.Value;
            bool precioEsValido = double.TryParse(txtPrecioUnitarioP3.Text, out precio);
            double total = double.Parse(txtTotalP3.Text);

            string nombreProducto = txtProductP3.Text;

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
                {
                 
                    double precioUnitario = Convert.ToDouble(txtPrecioUnitarioP3.Text);
                    //Agregar los valores a las listas
                    LProductos.Add(nombreProducto);
                    LunidadesCompradas.Add(unidades);
                    LprecioUnitario.Add(precioUnitario);
                    Ltotal.Add(total);

                    //Acá únicamente empezamos a limpiar los datos del formulario para poder registrar otro producto
                    txtPrecioUnitarioP3.Text = "";
                    txtProductP3.Text = "";
                    txtTotalP3.Text = "0.0";
                    slideUnidadesP3.Value = 0;//volvemos a hacer que el slide tenga como valor el 0
                    MessageBox.Show("Compra efectuada con éxito");
                    txtProductP3.Focus();//para poner el foco dentro del primer campo de texto

                    dtComprasP3.Rows.Clear();

                        ImprimirCompras();




                }
            }

        }

        private void btnActualizarP3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarP3_Click(object sender, EventArgs e)
        {
            int cantidadFilasSeleccionadas = dtComprasP3.SelectedRows.Count;

            if (cantidadFilasSeleccionadas <= 0)
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
            else {
                if (string.IsNullOrEmpty(nombreProductoEliminar))
                {
                    
                    MessageBox.Show("No has seleccionado un producto de la tabla, primero presiónalo");
                }
                else {
                    if (existeProducto(nombreProductoEliminar)) {
                        int posEliminar = IndiceDelElemento(nombreProductoEliminar);
                        if (posEliminar < 0)
                        { 
                            MessageBox.Show("El producto no existe o fue eliminado");
                        }
                        else{
                            EliminarCompra(posEliminar);
                            MessageBox.Show("Se ha eliminado correctamente la compra");
                            ImprimirCompras();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Elimina la información de las listas por medio de la posición indicada
        /// </summary>
        /// <param name="pos">Es la posición de la cual se eliminará toda la información</param>
        private void EliminarCompra(int pos)
        {
            LProductos.RemoveAt(pos);
            LprecioUnitario.RemoveAt(pos);
            LunidadesCompradas.RemoveAt(pos);
            Ltotal.RemoveAt(pos);
        }

        /// <summary>
        /// Obtiene el indice del elemento a buscar
        /// </summary>
        /// <param name="elemento">Elemento a buscar dentro de la lista</param>
        /// <returns>Posición donde fue encontrado el elemento</returns>
        private int IndiceDelElemento(string elemento)
        {
            return LProductos.IndexOf(elemento);
        }

        /// <summary>
        /// Determina si el producto indicado, existe o no dentro de la lista
        /// </summary>
        /// <param name="nombreProducto">Cadena (nombre del producto) a buscar dentro del arreglo</param>
        /// <returns>boolean true: existe False: no existe</returns>
        private bool existeProducto(string nombreProducto)
        {
            return LProductos.Contains(nombreProducto);
        }

       

        private void dtComprasP3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtComprasP3.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtComprasP3.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            nombreProductoEliminar = fila.Cells[0].Value.ToString();
            txtProductP3.Text = nombreProductoEliminar;
            txtPrecioUnitarioP3.Text = fila.Cells[1].Value.ToString();
            slideUnidadesP3.Value = int.Parse(fila.Cells[2].Value.ToString());
            txtTotalP3.Text = fila.Cells[3].Value.ToString();

            Console.WriteLine(nombreProductoEliminar);
        }

        private void dtComprasP3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
