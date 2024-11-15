namespace Taller
{
    partial class RegistrarMaterialForm
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
            this.ConfirmarRegistrarMaterial = new System.Windows.Forms.Button();
            this.Identificador = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.IdentificadorLibro = new System.Windows.Forms.TextBox();
            this.TituloLibro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConfirmarRegistrarMaterial
            // 
            this.ConfirmarRegistrarMaterial.Location = new System.Drawing.Point(340, 236);
            this.ConfirmarRegistrarMaterial.Name = "ConfirmarRegistrarMaterial";
            this.ConfirmarRegistrarMaterial.Size = new System.Drawing.Size(114, 35);
            this.ConfirmarRegistrarMaterial.TabIndex = 0;
            this.ConfirmarRegistrarMaterial.Text = "Confirmar registro";
            this.ConfirmarRegistrarMaterial.UseVisualStyleBackColor = true;
            this.ConfirmarRegistrarMaterial.Click += new System.EventHandler(this.ConfirmarRegistrarMaterial_Click);
            // 
            // Identificador
            // 
            this.Identificador.AutoSize = true;
            this.Identificador.Location = new System.Drawing.Point(211, 135);
            this.Identificador.Name = "Identificador";
            this.Identificador.Size = new System.Drawing.Size(65, 13);
            this.Identificador.TabIndex = 1;
            this.Identificador.Text = "Identificador";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(221, 190);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Titulo";
            // 
            // IdentificadorLibro
            // 
            this.IdentificadorLibro.Location = new System.Drawing.Point(340, 132);
            this.IdentificadorLibro.Name = "IdentificadorLibro";
            this.IdentificadorLibro.Size = new System.Drawing.Size(100, 20);
            this.IdentificadorLibro.TabIndex = 3;
            // 
            // TituloLibro
            // 
            this.TituloLibro.Location = new System.Drawing.Point(340, 187);
            this.TituloLibro.Name = "TituloLibro";
            this.TituloLibro.Size = new System.Drawing.Size(100, 20);
            this.TituloLibro.TabIndex = 4;
            // 
            // RegistrarMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TituloLibro);
            this.Controls.Add(this.IdentificadorLibro);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Identificador);
            this.Controls.Add(this.ConfirmarRegistrarMaterial);
            this.Name = "RegistrarMaterialForm";
            this.Text = "RegistrarMaterialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarRegistrarMaterial;
        private System.Windows.Forms.Label Identificador;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox IdentificadorLibro;
        private System.Windows.Forms.TextBox TituloLibro;
    }
}