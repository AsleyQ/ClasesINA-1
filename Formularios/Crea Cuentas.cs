using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Crea_Cuentas : Form
    {
        //Variable global para accederla desde el otro formulario
        public static String usuario="";
        public Crea_Cuentas()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtUsuarioCrear.Text.Equals(""))
            {
                MessageBox.Show("No ingresaste el nombre de usuario");
            }
            else {
                if (txtContrasennia.Text.Equals("") || txtRepiteContrasennia.Text.Equals(""))
                {
                    MessageBox.Show("No ingresaste la contraseña");
                }
                else {
                    if (!txtContrasennia.Text.Equals(txtRepiteContrasennia.Text))
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                    else
                    {
                        // Console.WriteLine(Login.usuario[0]);
                        //Código para empezar a crear el usuario 
                        string usuarioRegistrar = txtUsuarioCrear.Text; //Capturo el usuario digitando en el txt
                         string contrasennia = txtContrasennia.Text;

                        // Console.WriteLine(usuarioRegistrar);
                        bool existe = Array.Exists(Login.usuario, filtro => filtro ==usuarioRegistrar);
                        
                        if (existe)  //En caso de que realmente ya esté registrado en la colección
                        {  //entonces mostramos un mensaje al usuario indicando que ya existe
                            MessageBox.Show($"El usuario {usuarioRegistrar} ya existe dentro de la base de datos");
                        }
                        else //en caso de que no se haya registrado entonces, lo registramos
                        { //primero hacemos crecer los vectores para darle espacio al nuevo usuario (usuario,contraseña)
                            Array.Resize(ref Login.usuario, Login.usuario.Length + 1);
                            Array.Resize(ref Login.contrasennia,Login.contrasennia.Length + 1);

                            Login.usuario[Login.usuario.Length - 1] = usuarioRegistrar;
                            Login.contrasennia[Login.contrasennia.Length - 1]= contrasennia;

                            MessageBox.Show($"Usuario: {usuarioRegistrar} creado exitosamente!");

                            DialogResult respuesta = MessageBox.Show("Deseas autenticarte con este usuario? ","Pregunta", 
                                MessageBoxButtons.OKCancel );
                            switch (respuesta)
                            {
                                case DialogResult.OK:
                                    usuario = usuarioRegistrar;
                                    this.Dispose();
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }

                        
                        }
                    }
                }
            }
        } // Finaliza el evento del bóton
    }
}
