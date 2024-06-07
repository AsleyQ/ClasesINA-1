namespace ClasesINA.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.txtContrasenniaL = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.btnIngresar);
            this.materialCard1.Controls.Add(this.txtContrasenniaL);
            this.materialCard1.Controls.Add(this.txtUsuario);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(221, 131);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(390, 244);
            this.materialCard1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Crear Cuenta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(257, 169);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtContrasenniaL
            // 
            this.txtContrasenniaL.AllowPromptAsInput = true;
            this.txtContrasenniaL.AnimateReadOnly = false;
            this.txtContrasenniaL.AsciiOnly = false;
            this.txtContrasenniaL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasenniaL.BeepOnError = false;
            this.txtContrasenniaL.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasenniaL.Depth = 0;
            this.txtContrasenniaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenniaL.HidePromptOnLeave = false;
            this.txtContrasenniaL.HideSelection = true;
            this.txtContrasenniaL.Hint = "Contraseña";
            this.txtContrasenniaL.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtContrasenniaL.LeadingIcon = null;
            this.txtContrasenniaL.Location = new System.Drawing.Point(98, 112);
            this.txtContrasenniaL.Mask = "";
            this.txtContrasenniaL.MaxLength = 32767;
            this.txtContrasenniaL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenniaL.Name = "txtContrasenniaL";
            this.txtContrasenniaL.PasswordChar = '*';
            this.txtContrasenniaL.PrefixSuffixText = null;
            this.txtContrasenniaL.PromptChar = '_';
            this.txtContrasenniaL.ReadOnly = false;
            this.txtContrasenniaL.RejectInputOnFirstFailure = false;
            this.txtContrasenniaL.ResetOnPrompt = true;
            this.txtContrasenniaL.ResetOnSpace = true;
            this.txtContrasenniaL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasenniaL.SelectedText = "";
            this.txtContrasenniaL.SelectionLength = 0;
            this.txtContrasenniaL.SelectionStart = 0;
            this.txtContrasenniaL.ShortcutsEnabled = true;
            this.txtContrasenniaL.Size = new System.Drawing.Size(250, 48);
            this.txtContrasenniaL.SkipLiterals = true;
            this.txtContrasenniaL.TabIndex = 2;
            this.txtContrasenniaL.TabStop = false;
            this.txtContrasenniaL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasenniaL.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasenniaL.TrailingIcon = null;
            this.txtContrasenniaL.UseSystemPasswordChar = false;
            this.txtContrasenniaL.ValidatingType = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.Hint = "Ingrese el usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(98, 42);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffixText = null;
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(250, 48);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(221, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(213, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Bienvenido(a) a Tienda Stylos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.Name = "Login";
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContrasenniaL;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
    }
}