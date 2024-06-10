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
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }

        private void facturarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //Quitamos forms si ya los hay
            //Creamos una instancia del formulario a abrir
            Principal facturacion = new Principal();
            //Le indicamos que no es el principal (sino que es secundario)
            facturacion.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            facturacion.AutoScroll = true;
            //Quitamos bordes
            facturacion.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            facturacion.Dock = DockStyle.Fill;  
            // y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(facturacion);

            facturacion.Show();
        }

        private void crearCuentaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //Quitamos forms si ya los hay
            //Creamos una instancia del formulario a abrir
            Crea_Cuentas NuevaCuenta = new Crea_Cuentas();
            //Le indicamos que no es el principal (sino que es secundario)
            NuevaCuenta.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            NuevaCuenta.AutoScroll = true;
            //Quitamos bordes
            NuevaCuenta.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            // y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(NuevaCuenta);

            NuevaCuenta.Show();
        }

        private void Principal2_Load(object sender, EventArgs e)
        {
            facturarProductosToolStripMenuItem.ToolTipText = "Esta vista es para realizar facturación";
        }

        private void Principal2_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void formularioDeListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //Quitamos forms si ya los hay
            //Creamos una instancia del formulario a abrir
            Listas listas = new Listas();
            //Le indicamos que no es el principal (sino que es secundario)
            listas.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            listas.AutoScroll = true;
            //Quitamos bordes
            listas.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            // y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(listas);

            listas.Show();
        }

        private void facturarConListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear(); //Quitamos forms si ya los hay
            //Creamos una instancia del formulario a abrir
            Principal3 Facturar_listas = new Principal3();
            //Le indicamos que no es el principal (sino que es secundario)
            Facturar_listas.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            Facturar_listas.AutoScroll = true;
            //Quitamos bordes
            Facturar_listas.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            // y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(Facturar_listas);

            Facturar_listas.Show();
        }
    }
}
