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

    public partial class Listas : Form
    {
        //Creamos una instancia del tipo list de tipo entero
        List<int> numeros = new List<int>(); //Lista vacia

        //Lista con valores predefinidos al momento de la ejecución
        List<int> numerosPredeterminados = new List<int> { 10, 20, 30, 40 };
        public Listas()
        {
            InitializeComponent();
        }

        private void btnMostrarValores_Click(object sender, EventArgs e)
        {
            foreach (int numero in numerosPredeterminados)
            {
                Console.WriteLine(numero);

            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            if (esNumero)
            {
                numerosPredeterminados.Add(numero);
                //txtNumeros.Text= "";
                btnMostrarValores_Click(sender, e);


            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            /*int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            if (esNumero)
            {
                numerosPredeterminados.Remove(numero);
                btnMostrarValores_Click(sender, e); */
            int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            if (esNumero)
            {
                bool existe = numerosPredeterminados.Exists(filtro => filtro.Equals(numero));
                if (existe)
                {
                    numerosPredeterminados.Remove(numero);
                    MessageBox.Show($"El número {numero} fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnMostrarValores_Click(sender, e);
                }
                else
                {
                    MessageBox.Show($"El número {numero} no existe", "información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //inicia la definición de funciones del formulario
        /// <summary>
        /// Determina si existe o no el valor dentro de la colección
        /// </summary>
        /// <param name="elemento">Es el valor que se buscará en la colección</param>
        /// <returns></returns>



        private bool ElementoExiste(int elemento)
        {
            bool existe = numerosPredeterminados.Exists(filtro => filtro == elemento);
            return existe;
        }

        /// <summary>
        /// Registra un valor nuevo a la lista numerosPredeterminados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="valorNuevo">Es el valor a registrar en la lista</param>

        private void AgregarElemento(int valorNuevo)
        {
            numerosPredeterminados.Add(valorNuevo);
        } 
        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            int valor = int.Parse(txtNumero.Text);

            if (ElementoExiste(valor))
            {
                MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        
    }// Finaliza la clase

}

