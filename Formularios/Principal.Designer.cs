namespace ClasesINA.Formularios
{
    partial class Principal
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
            this.txtProducto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrecioUnitario = new MaterialSkin.Controls.MaterialTextBox2();
            this.slideUnidades = new MaterialSkin.Controls.MaterialSlider();
            this.btnProcesarCompra = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesCompradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.AnimateReadOnly = false;
            this.txtProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProducto.Depth = 0;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProducto.HideSelection = true;
            this.txtProducto.Hint = "Nombre del producto";
            this.txtProducto.LeadingIcon = null;
            this.txtProducto.Location = new System.Drawing.Point(65, 153);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.PrefixSuffixText = null;
            this.txtProducto.ReadOnly = false;
            this.txtProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.ShortcutsEnabled = true;
            this.txtProducto.Size = new System.Drawing.Size(271, 48);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TabStop = false;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProducto.TrailingIcon = null;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AnimateReadOnly = false;
            this.txtPrecioUnitario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecioUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioUnitario.Depth = 0;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioUnitario.HideSelection = true;
            this.txtPrecioUnitario.Hint = "Precio Unitario";
            this.txtPrecioUnitario.LeadingIcon = null;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(377, 153);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioUnitario.MaxLength = 32767;
            this.txtPrecioUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PasswordChar = '\0';
            this.txtPrecioUnitario.PrefixSuffixText = null;
            this.txtPrecioUnitario.ReadOnly = false;
            this.txtPrecioUnitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.SelectionLength = 0;
            this.txtPrecioUnitario.SelectionStart = 0;
            this.txtPrecioUnitario.ShortcutsEnabled = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(209, 48);
            this.txtPrecioUnitario.TabIndex = 1;
            this.txtPrecioUnitario.TabStop = false;
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioUnitario.TrailingIcon = null;
            this.txtPrecioUnitario.UseSystemPasswordChar = false;
            this.txtPrecioUnitario.Leave += new System.EventHandler(this.txtPrecioUnitario_Leave);
            // 
            // slideUnidades
            // 
            this.slideUnidades.Depth = 0;
            this.slideUnidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slideUnidades.Location = new System.Drawing.Point(659, 153);
            this.slideUnidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slideUnidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.slideUnidades.Name = "slideUnidades";
            this.slideUnidades.Size = new System.Drawing.Size(333, 40);
            this.slideUnidades.TabIndex = 2;
            this.slideUnidades.Text = "Unidades";
            this.slideUnidades.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.slideUnidades_onValueChanged);
            // 
            // btnProcesarCompra
            // 
            this.btnProcesarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcesarCompra.Depth = 0;
            this.btnProcesarCompra.HighEmphasis = true;
            this.btnProcesarCompra.Icon = null;
            this.btnProcesarCompra.Location = new System.Drawing.Point(65, 324);
            this.btnProcesarCompra.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnProcesarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesarCompra.Name = "btnProcesarCompra";
            this.btnProcesarCompra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcesarCompra.Size = new System.Drawing.Size(160, 36);
            this.btnProcesarCompra.TabIndex = 3;
            this.btnProcesarCompra.Text = "Procesar Compra";
            this.btnProcesarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcesarCompra.UseAccentColor = false;
            this.btnProcesarCompra.UseVisualStyleBackColor = true;
            this.btnProcesarCompra.Click += new System.EventHandler(this.btnProcesarCompra_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.Hint = "0.0";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(65, 235);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(208, 48);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // dtCompras
            // 
            this.dtCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.PrecioUnitario,
            this.UnidadesCompradas,
            this.Total});
            this.dtCompras.Location = new System.Drawing.Point(65, 379);
            this.dtCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 51;
            this.dtCompras.Size = new System.Drawing.Size(692, 144);
            this.dtCompras.TabIndex = 5;
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
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(767, 379);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(767, 438);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 554);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtCompras);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnProcesarCompra);
            this.Controls.Add(this.slideUnidades);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtProducto;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioUnitario;
        private MaterialSkin.Controls.MaterialSlider slideUnidades;
        private MaterialSkin.Controls.MaterialButton btnProcesarCompra;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private System.Windows.Forms.DataGridView dtCompras;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesCompradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}