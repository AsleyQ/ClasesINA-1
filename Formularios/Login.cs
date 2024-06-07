using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string passwdAutentica = txtContrasenniaL.Text;

            bool existeUsuario = Array.Exists(usuario, filtro => filtro == usuarioAutentica);
            bool existePasswd = Array.Exists(contrasennia,filtro => filtro == passwdAutentica);

            if (existePasswd && existeUsuario) {
                Principal principal = new Principal();
                principal.Show();
                Visible = false; //Ocultar la ventana
            }
            else
            {
                MessageBox.Show(
                    "Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
