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
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.btnProcesarCompra = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesCompradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.AnimateReadOnly = false;
            this.txtProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProducto.Depth = 0;
            this.txtProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProducto.HideSelection = true;
            this.txtProducto.Hint = "Nombre del producto";
            this.txtProducto.LeadingIcon = null;
            this.txtProducto.Location = new System.Drawing.Point(49, 124);
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
            this.txtProducto.Size = new System.Drawing.Size(203, 48);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TabStop = false;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProducto.TrailingIcon = null;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.HideSelection = true;
            this.txtPrecio.Hint = "Precio Unitario";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(283, 124);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PrefixSuffixText = null;
            this.txtPrecio.ReadOnly = false;
            this.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(157, 48);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.TrailingIcon = null;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(494, 124);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.Size = new System.Drawing.Size(250, 40);
            this.materialSlider1.TabIndex = 2;
            this.materialSlider1.Text = "Unidades";
            // 
            // btnProcesarCompra
            // 
            this.btnProcesarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcesarCompra.Depth = 0;
            this.btnProcesarCompra.HighEmphasis = true;
            this.btnProcesarCompra.Icon = null;
            this.btnProcesarCompra.Location = new System.Drawing.Point(49, 263);
            this.btnProcesarCompra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcesarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesarCompra.Name = "btnProcesarCompra";
            this.btnProcesarCompra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcesarCompra.Size = new System.Drawing.Size(160, 36);
            this.btnProcesarCompra.TabIndex = 3;
            this.btnProcesarCompra.Text = "Procesar Compra";
            this.btnProcesarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcesarCompra.UseAccentColor = false;
            this.btnProcesarCompra.UseVisualStyleBackColor = true;
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
            this.txtTotal.Location = new System.Drawing.Point(49, 191);
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
            this.txtTotal.Size = new System.Drawing.Size(156, 48);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.PrecioUnitario,
            this.UnidadesCompradas,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(49, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 117);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(575, 308);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.btnActualizar.Location = new System.Drawing.Point(575, 356);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(88, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // UnidadesCompradas
            // 
            this.UnidadesCompradas.HeaderText = "Unidades Compradas";
            this.UnidadesCompradas.Name = "UnidadesCompradas";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnProcesarCompra);
            this.Controls.Add(this.materialSlider1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProducto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtProducto;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecio;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialButton btnProcesarCompra;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesCompradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}