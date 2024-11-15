namespace Taller
{
    partial class TransaccionesForm
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
            this.ButtonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.ButtonRegistrarDevolucion = new System.Windows.Forms.Button();
            this.IdPersona = new System.Windows.Forms.Label();
            this.IdMaterial = new System.Windows.Forms.Label();
            this.CedulaPersona = new System.Windows.Forms.TextBox();
            this.Identificador_material = new System.Windows.Forms.TextBox();
            this.ButtonAdicionarMaterial = new System.Windows.Forms.Button();
            this.ButtonConsultarHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonRegistrarPrestamo
            // 
            this.ButtonRegistrarPrestamo.Location = new System.Drawing.Point(37, 252);
            this.ButtonRegistrarPrestamo.Name = "ButtonRegistrarPrestamo";
            this.ButtonRegistrarPrestamo.Size = new System.Drawing.Size(114, 39);
            this.ButtonRegistrarPrestamo.TabIndex = 0;
            this.ButtonRegistrarPrestamo.Text = "Registrar prestamo";
            this.ButtonRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.ButtonRegistrarPrestamo.Click += new System.EventHandler(this.ButtonRegistrarPrestamo_Click);
            // 
            // ButtonRegistrarDevolucion
            // 
            this.ButtonRegistrarDevolucion.Location = new System.Drawing.Point(223, 252);
            this.ButtonRegistrarDevolucion.Name = "ButtonRegistrarDevolucion";
            this.ButtonRegistrarDevolucion.Size = new System.Drawing.Size(114, 39);
            this.ButtonRegistrarDevolucion.TabIndex = 1;
            this.ButtonRegistrarDevolucion.Text = "Registrar devolucion";
            this.ButtonRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.ButtonRegistrarDevolucion.Click += new System.EventHandler(this.ButtonRegistrarDevolucion_Click);
            // 
            // IdPersona
            // 
            this.IdPersona.AutoSize = true;
            this.IdPersona.Location = new System.Drawing.Point(146, 68);
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Size = new System.Drawing.Size(94, 13);
            this.IdPersona.TabIndex = 2;
            this.IdPersona.Text = "Número de cédula";
            // 
            // IdMaterial
            // 
            this.IdMaterial.AutoSize = true;
            this.IdMaterial.Location = new System.Drawing.Point(135, 136);
            this.IdMaterial.Name = "IdMaterial";
            this.IdMaterial.Size = new System.Drawing.Size(126, 13);
            this.IdMaterial.TabIndex = 3;
            this.IdMaterial.Text = "Identificación del material";
            // 
            // CedulaPersona
            // 
            this.CedulaPersona.Location = new System.Drawing.Point(400, 61);
            this.CedulaPersona.Name = "CedulaPersona";
            this.CedulaPersona.Size = new System.Drawing.Size(100, 20);
            this.CedulaPersona.TabIndex = 4;
            // 
            // Identificador_material
            // 
            this.Identificador_material.Location = new System.Drawing.Point(400, 129);
            this.Identificador_material.Name = "Identificador_material";
            this.Identificador_material.Size = new System.Drawing.Size(100, 20);
            this.Identificador_material.TabIndex = 5;
            // 
            // ButtonAdicionarMaterial
            // 
            this.ButtonAdicionarMaterial.Location = new System.Drawing.Point(421, 252);
            this.ButtonAdicionarMaterial.Name = "ButtonAdicionarMaterial";
            this.ButtonAdicionarMaterial.Size = new System.Drawing.Size(114, 39);
            this.ButtonAdicionarMaterial.TabIndex = 6;
            this.ButtonAdicionarMaterial.Text = "Adicionar material";
            this.ButtonAdicionarMaterial.UseVisualStyleBackColor = true;
            this.ButtonAdicionarMaterial.Click += new System.EventHandler(this.ButtonAdicionarMaterial_Click);
            // 
            // ButtonConsultarHistorial
            // 
            this.ButtonConsultarHistorial.Location = new System.Drawing.Point(614, 257);
            this.ButtonConsultarHistorial.Name = "ButtonConsultarHistorial";
            this.ButtonConsultarHistorial.Size = new System.Drawing.Size(118, 34);
            this.ButtonConsultarHistorial.TabIndex = 7;
            this.ButtonConsultarHistorial.Text = "Consultar historial de transacciones";
            this.ButtonConsultarHistorial.UseVisualStyleBackColor = true;
            this.ButtonConsultarHistorial.Click += new System.EventHandler(this.ButtonConsultarHistorial_Click);
            // 
            // TransaccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonConsultarHistorial);
            this.Controls.Add(this.ButtonAdicionarMaterial);
            this.Controls.Add(this.Identificador_material);
            this.Controls.Add(this.CedulaPersona);
            this.Controls.Add(this.IdMaterial);
            this.Controls.Add(this.IdPersona);
            this.Controls.Add(this.ButtonRegistrarDevolucion);
            this.Controls.Add(this.ButtonRegistrarPrestamo);
            this.Name = "TransaccionesForm";
            this.Text = "TransaccionesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRegistrarPrestamo;
        private System.Windows.Forms.Button ButtonRegistrarDevolucion;
        private System.Windows.Forms.Label IdPersona;
        private System.Windows.Forms.Label IdMaterial;
        private System.Windows.Forms.TextBox CedulaPersona;
        private System.Windows.Forms.TextBox Identificador_material;
        private System.Windows.Forms.Button ButtonAdicionarMaterial;
        private System.Windows.Forms.Button ButtonConsultarHistorial;
    }
}