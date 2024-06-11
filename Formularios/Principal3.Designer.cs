namespace ClasesINA.Formularios
{
    partial class Principal3
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
            this.txtProductP3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrecioUnitarioP3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.slideUnidadesP3 = new MaterialSkin.Controls.MaterialSlider();
            this.txtTotalP3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnProcesarCompraP3 = new MaterialSkin.Controls.MaterialButton();
            this.dtComprasP3 = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesCompradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarP3 = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizarP3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtComprasP3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductP3
            // 
            this.txtProductP3.AnimateReadOnly = false;
            this.txtProductP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductP3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductP3.Depth = 0;
            this.txtProductP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductP3.HideSelection = true;
            this.txtProductP3.Hint = "Nombre del producto";
            this.txtProductP3.LeadingIcon = null;
            this.txtProductP3.Location = new System.Drawing.Point(55, 66);
            this.txtProductP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductP3.MaxLength = 32767;
            this.txtProductP3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductP3.Name = "txtProductP3";
            this.txtProductP3.PasswordChar = '\0';
            this.txtProductP3.PrefixSuffixText = null;
            this.txtProductP3.ReadOnly = false;
            this.txtProductP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductP3.SelectedText = "";
            this.txtProductP3.SelectionLength = 0;
            this.txtProductP3.SelectionStart = 0;
            this.txtProductP3.ShortcutsEnabled = true;
            this.txtProductP3.Size = new System.Drawing.Size(271, 48);
            this.txtProductP3.TabIndex = 1;
            this.txtProductP3.TabStop = false;
            this.txtProductP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductP3.TrailingIcon = null;
            this.txtProductP3.UseSystemPasswordChar = false;
            // 
            // txtPrecioUnitarioP3
            // 
            this.txtPrecioUnitarioP3.AnimateReadOnly = false;
            this.txtPrecioUnitarioP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecioUnitarioP3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioUnitarioP3.Depth = 0;
            this.txtPrecioUnitarioP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioUnitarioP3.HideSelection = true;
            this.txtPrecioUnitarioP3.Hint = "Precio Unitario";
            this.txtPrecioUnitarioP3.LeadingIcon = null;
            this.txtPrecioUnitarioP3.Location = new System.Drawing.Point(357, 66);
            this.txtPrecioUnitarioP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnitarioP3.MaxLength = 32767;
            this.txtPrecioUnitarioP3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioUnitarioP3.Name = "txtPrecioUnitarioP3";
            this.txtPrecioUnitarioP3.PasswordChar = '\0';
            this.txtPrecioUnitarioP3.PrefixSuffixText = null;
            this.txtPrecioUnitarioP3.ReadOnly = false;
            this.txtPrecioUnitarioP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioUnitarioP3.SelectedText = "";
            this.txtPrecioUnitarioP3.SelectionLength = 0;
            this.txtPrecioUnitarioP3.SelectionStart = 0;
            this.txtPrecioUnitarioP3.ShortcutsEnabled = true;
            this.txtPrecioUnitarioP3.Size = new System.Drawing.Size(209, 48);
            this.txtPrecioUnitarioP3.TabIndex = 2;
            this.txtPrecioUnitarioP3.TabStop = false;
            this.txtPrecioUnitarioP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioUnitarioP3.TrailingIcon = null;
            this.txtPrecioUnitarioP3.UseSystemPasswordChar = false;
            this.txtPrecioUnitarioP3.Click += new System.EventHandler(this.txtPrecioUnitarioP3_Click);
            // 
            // slideUnidadesP3
            // 
            this.slideUnidadesP3.Depth = 0;
            this.slideUnidadesP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slideUnidadesP3.Location = new System.Drawing.Point(592, 66);
            this.slideUnidadesP3.Margin = new System.Windows.Forms.Padding(4);
            this.slideUnidadesP3.MouseState = MaterialSkin.MouseState.HOVER;
            this.slideUnidadesP3.Name = "slideUnidadesP3";
            this.slideUnidadesP3.Size = new System.Drawing.Size(333, 40);
            this.slideUnidadesP3.TabIndex = 3;
            this.slideUnidadesP3.Text = "Unidades";
            this.slideUnidadesP3.Click += new System.EventHandler(this.slideUnidadesP3_Click);
            // 
            // txtTotalP3
            // 
            this.txtTotalP3.AnimateReadOnly = false;
            this.txtTotalP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalP3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalP3.Depth = 0;
            this.txtTotalP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalP3.HideSelection = true;
            this.txtTotalP3.Hint = "0.0";
            this.txtTotalP3.LeadingIcon = null;
            this.txtTotalP3.Location = new System.Drawing.Point(55, 165);
            this.txtTotalP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalP3.MaxLength = 32767;
            this.txtTotalP3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalP3.Name = "txtTotalP3";
            this.txtTotalP3.PasswordChar = '\0';
            this.txtTotalP3.PrefixSuffixText = null;
            this.txtTotalP3.ReadOnly = true;
            this.txtTotalP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalP3.SelectedText = "";
            this.txtTotalP3.SelectionLength = 0;
            this.txtTotalP3.SelectionStart = 0;
            this.txtTotalP3.ShortcutsEnabled = true;
            this.txtTotalP3.Size = new System.Drawing.Size(208, 48);
            this.txtTotalP3.TabIndex = 5;
            this.txtTotalP3.TabStop = false;
            this.txtTotalP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalP3.TrailingIcon = null;
            this.txtTotalP3.UseSystemPasswordChar = false;
            // 
            // btnProcesarCompraP3
            // 
            this.btnProcesarCompraP3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesarCompraP3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcesarCompraP3.Depth = 0;
            this.btnProcesarCompraP3.HighEmphasis = true;
            this.btnProcesarCompraP3.Icon = null;
            this.btnProcesarCompraP3.Location = new System.Drawing.Point(756, 258);
            this.btnProcesarCompraP3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnProcesarCompraP3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesarCompraP3.Name = "btnProcesarCompraP3";
            this.btnProcesarCompraP3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcesarCompraP3.Size = new System.Drawing.Size(160, 36);
            this.btnProcesarCompraP3.TabIndex = 6;
            this.btnProcesarCompraP3.Text = "Procesar Compra";
            this.btnProcesarCompraP3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcesarCompraP3.UseAccentColor = false;
            this.btnProcesarCompraP3.UseVisualStyleBackColor = true;
            this.btnProcesarCompraP3.Click += new System.EventHandler(this.btnProcesarCompraP3_Click);
            // 
            // dtComprasP3
            // 
            this.dtComprasP3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtComprasP3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtComprasP3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.PrecioUnitario,
            this.UnidadesCompradas,
            this.Total});
            this.dtComprasP3.Location = new System.Drawing.Point(55, 258);
            this.dtComprasP3.Margin = new System.Windows.Forms.Padding(4);
            this.dtComprasP3.Name = "dtComprasP3";
            this.dtComprasP3.RowHeadersWidth = 51;
            this.dtComprasP3.Size = new System.Drawing.Size(692, 162);
            this.dtComprasP3.TabIndex = 7;
            this.dtComprasP3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtComprasP3_CellContentClick);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // UnidadesCompradas
            // 
            this.UnidadesCompradas.HeaderText = "Unidades Compradas";
            this.UnidadesCompradas.MinimumWidth = 6;
            this.UnidadesCompradas.Name = "UnidadesCompradas";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // btnEliminarP3
            // 
            this.btnEliminarP3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarP3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarP3.Depth = 0;
            this.btnEliminarP3.HighEmphasis = true;
            this.btnEliminarP3.Icon = null;
            this.btnEliminarP3.Location = new System.Drawing.Point(756, 377);
            this.btnEliminarP3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEliminarP3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarP3.Name = "btnEliminarP3";
            this.btnEliminarP3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarP3.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarP3.TabIndex = 8;
            this.btnEliminarP3.Text = "Eliminar";
            this.btnEliminarP3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarP3.UseAccentColor = false;
            this.btnEliminarP3.UseVisualStyleBackColor = true;
            this.btnEliminarP3.Click += new System.EventHandler(this.btnEliminarP3_Click);
            // 
            // btnActualizarP3
            // 
            this.btnActualizarP3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarP3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarP3.Depth = 0;
            this.btnActualizarP3.HighEmphasis = true;
            this.btnActualizarP3.Icon = null;
            this.btnActualizarP3.Location = new System.Drawing.Point(756, 318);
            this.btnActualizarP3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnActualizarP3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarP3.Name = "btnActualizarP3";
            this.btnActualizarP3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarP3.Size = new System.Drawing.Size(109, 36);
            this.btnActualizarP3.TabIndex = 9;
            this.btnActualizarP3.Text = "Actualizar";
            this.btnActualizarP3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarP3.UseAccentColor = false;
            this.btnActualizarP3.UseVisualStyleBackColor = true;
            this.btnActualizarP3.Click += new System.EventHandler(this.btnActualizarP3_Click);
            // 
            // Principal3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnActualizarP3);
            this.Controls.Add(this.btnEliminarP3);
            this.Controls.Add(this.dtComprasP3);
            this.Controls.Add(this.btnProcesarCompraP3);
            this.Controls.Add(this.txtTotalP3);
            this.Controls.Add(this.slideUnidadesP3);
            this.Controls.Add(this.txtPrecioUnitarioP3);
            this.Controls.Add(this.txtProductP3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal3";
            this.Text = "Principal3";
            this.Load += new System.EventHandler(this.Principal3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtComprasP3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtProductP3;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioUnitarioP3;
        private MaterialSkin.Controls.MaterialSlider slideUnidadesP3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalP3;
        private MaterialSkin.Controls.MaterialButton btnProcesarCompraP3;
        private System.Windows.Forms.DataGridView dtComprasP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesCompradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialButton btnEliminarP3;
        private MaterialSkin.Controls.MaterialButton btnActualizarP3;
    }
}