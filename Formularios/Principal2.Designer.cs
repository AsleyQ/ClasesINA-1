﻿namespace ClasesINA.Formularios
{
    partial class Principal2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarConListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarProductosToolStripMenuItem,
            this.facturarConListasToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturarProductosToolStripMenuItem
            // 
            this.facturarProductosToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.icons8_facturación_16;
            this.facturarProductosToolStripMenuItem.Name = "facturarProductosToolStripMenuItem";
            this.facturarProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.facturarProductosToolStripMenuItem.ShowShortcutKeys = false;
            this.facturarProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturarProductosToolStripMenuItem.Text = "Facturar productos";
            this.facturarProductosToolStripMenuItem.ToolTipText = "Esta es una vista para realizar la facturación de productos";
            this.facturarProductosToolStripMenuItem.Click += new System.EventHandler(this.facturarProductosToolStripMenuItem_Click);
            // 
            // facturarConListasToolStripMenuItem
            // 
            this.facturarConListasToolStripMenuItem.Name = "facturarConListasToolStripMenuItem";
            this.facturarConListasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturarConListasToolStripMenuItem.Text = "Facturar con listas";
            this.facturarConListasToolStripMenuItem.Click += new System.EventHandler(this.facturarConListasToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaDeUsuarioToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // crearCuentaDeUsuarioToolStripMenuItem
            // 
            this.crearCuentaDeUsuarioToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.icons8_cuentas_16;
            this.crearCuentaDeUsuarioToolStripMenuItem.Name = "crearCuentaDeUsuarioToolStripMenuItem";
            this.crearCuentaDeUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.crearCuentaDeUsuarioToolStripMenuItem.ShowShortcutKeys = false;
            this.crearCuentaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.crearCuentaDeUsuarioToolStripMenuItem.Text = "Crear cuenta de usuario";
            this.crearCuentaDeUsuarioToolStripMenuItem.ToolTipText = "Esta es una vista para crear una nueva cuenta de usuario ";
            this.crearCuentaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaDeUsuarioToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeListasToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // formularioDeListasToolStripMenuItem
            // 
            this.formularioDeListasToolStripMenuItem.Name = "formularioDeListasToolStripMenuItem";
            this.formularioDeListasToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.formularioDeListasToolStripMenuItem.Text = "Formulario de listas";
            this.formularioDeListasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeListasToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 30);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1067, 524);
            this.Contenedor.TabIndex = 1;
            // 
            // Principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal2";
            this.Text = "Principal2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal2_FormClosed);
            this.Load += new System.EventHandler(this.Principal2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarConListasToolStripMenuItem;
    }
}