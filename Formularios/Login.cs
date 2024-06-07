using MaterialSkin;
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
    public partial class Login : MaterialForm
    {
        //Vectores necesarios para el sistema

        public static string[] usuario = { "Admin" }; //con un usuario por defecto
        public static string[] contrasennia = { "123" }; //con una contraseña por defecto
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //Acá vamos a configurar el color 
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                 Primary.Blue700, Primary.Blue700,
                 Primary.Blue700, Accent.Indigo200,
                 TextShade.WHITE
                );
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Crea_Cuentas NuevaCuenta = new Crea_Cuentas(); // Instancia para llamar al botón Crea_Cuentas
            NuevaCuenta.Show();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Crea_Cuentas.usuario)){
                txtUsuario.Text = Crea_Cuentas.usuario;
            }
        }
    }
}
