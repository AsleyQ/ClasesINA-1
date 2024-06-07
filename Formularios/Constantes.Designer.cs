namespace ClasesINA.Formularios
{
    partial class Constantes
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
            this.lblValorConstante = new System.Windows.Forms.Label();
            this.btnImprimirConstante = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblValorConstante
            // 
            this.lblValorConstante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValorConstante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorConstante.Location = new System.Drawing.Point(33, 179);
            this.lblValorConstante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorConstante.Name = "lblValorConstante";
            this.lblValorConstante.Size = new System.Drawing.Size(247, 36);
            this.lblValorConstante.TabIndex = 0;
            this.lblValorConstante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimirConstante
            // 
            this.btnImprimirConstante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimirConstante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimirConstante.Depth = 0;
            this.btnImprimirConstante.HighEmphasis = true;
            this.btnImprimirConstante.Icon = null;
            this.btnImprimirConstante.Location = new System.Drawing.Point(33, 120);
            this.btnImprimirConstante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimirConstante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimirConstante.Name = "btnImprimirConstante";
            this.btnImprimirConstante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimirConstante.Size = new System.Drawing.Size(273, 36);
            this.btnImprimirConstante.TabIndex = 2;
            this.btnImprimirConstante.Text = "Mostrar valor de la constante";
            this.btnImprimirConstante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimirConstante.UseAccentColor = false;
            this.btnImprimirConstante.UseVisualStyleBackColor = true;
            this.btnImprimirConstante.Click += new System.EventHandler(this.btnImprimirConstante_Click_1);
            // 
            // Constantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnImprimirConstante);
            this.Controls.Add(this.lblValorConstante);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Constantes";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "Constantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorConstante;
        private MaterialSkin.Controls.MaterialButton btnImprimirConstante;
    }
}