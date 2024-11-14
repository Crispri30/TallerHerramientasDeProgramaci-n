namespace Taller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonRegistrarPersona = new System.Windows.Forms.Button();
            this.ButtonEliminarPersona = new System.Windows.Forms.Button();
            this.ButtonRegistrarMaterial = new System.Windows.Forms.Button();
            this.ButtonConsultarHistorial = new System.Windows.Forms.Button();
            this.ButtonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.ButtonRegistrarDevolucion = new System.Windows.Forms.Button();
            this.ButtonAdicionarMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonRegistrarPersona
            // 
            this.ButtonRegistrarPersona.Location = new System.Drawing.Point(129, 125);
            this.ButtonRegistrarPersona.Name = "ButtonRegistrarPersona";
            this.ButtonRegistrarPersona.Size = new System.Drawing.Size(108, 33);
            this.ButtonRegistrarPersona.TabIndex = 0;
            this.ButtonRegistrarPersona.Text = "Registrar persona";
            this.ButtonRegistrarPersona.UseVisualStyleBackColor = true;
            this.ButtonRegistrarPersona.Click += new System.EventHandler(this.ButtonRegistrarPersona_Click);
            // 
            // ButtonEliminarPersona
            // 
            this.ButtonEliminarPersona.Location = new System.Drawing.Point(129, 223);
            this.ButtonEliminarPersona.Name = "ButtonEliminarPersona";
            this.ButtonEliminarPersona.Size = new System.Drawing.Size(108, 33);
            this.ButtonEliminarPersona.TabIndex = 1;
            this.ButtonEliminarPersona.Text = "Eliminar persona";
            this.ButtonEliminarPersona.UseVisualStyleBackColor = true;
            // 
            // ButtonRegistrarMaterial
            // 
            this.ButtonRegistrarMaterial.Location = new System.Drawing.Point(310, 125);
            this.ButtonRegistrarMaterial.Name = "ButtonRegistrarMaterial";
            this.ButtonRegistrarMaterial.Size = new System.Drawing.Size(108, 33);
            this.ButtonRegistrarMaterial.TabIndex = 2;
            this.ButtonRegistrarMaterial.Text = "Registrar material";
            this.ButtonRegistrarMaterial.UseVisualStyleBackColor = true;
            this.ButtonRegistrarMaterial.Click += new System.EventHandler(this.ButtonRegistrarMaterial_Click);
            // 
            // ButtonConsultarHistorial
            // 
            this.ButtonConsultarHistorial.Location = new System.Drawing.Point(310, 191);
            this.ButtonConsultarHistorial.Name = "ButtonConsultarHistorial";
            this.ButtonConsultarHistorial.Size = new System.Drawing.Size(108, 33);
            this.ButtonConsultarHistorial.TabIndex = 3;
            this.ButtonConsultarHistorial.Text = "Consultar historial";
            this.ButtonConsultarHistorial.UseVisualStyleBackColor = true;
            // 
            // ButtonRegistrarPrestamo
            // 
            this.ButtonRegistrarPrestamo.Location = new System.Drawing.Point(524, 125);
            this.ButtonRegistrarPrestamo.Name = "ButtonRegistrarPrestamo";
            this.ButtonRegistrarPrestamo.Size = new System.Drawing.Size(108, 33);
            this.ButtonRegistrarPrestamo.TabIndex = 4;
            this.ButtonRegistrarPrestamo.Text = "Registrar prestamo";
            this.ButtonRegistrarPrestamo.UseVisualStyleBackColor = true;
            // 
            // ButtonRegistrarDevolucion
            // 
            this.ButtonRegistrarDevolucion.Location = new System.Drawing.Point(511, 177);
            this.ButtonRegistrarDevolucion.Name = "ButtonRegistrarDevolucion";
            this.ButtonRegistrarDevolucion.Size = new System.Drawing.Size(139, 47);
            this.ButtonRegistrarDevolucion.TabIndex = 5;
            this.ButtonRegistrarDevolucion.Text = "Registrar devolucion";
            this.ButtonRegistrarDevolucion.UseVisualStyleBackColor = true;
            // 
            // ButtonAdicionarMaterial
            // 
            this.ButtonAdicionarMaterial.Location = new System.Drawing.Point(511, 258);
            this.ButtonAdicionarMaterial.Name = "ButtonAdicionarMaterial";
            this.ButtonAdicionarMaterial.Size = new System.Drawing.Size(139, 47);
            this.ButtonAdicionarMaterial.TabIndex = 6;
            this.ButtonAdicionarMaterial.Text = "Adicionar material";
            this.ButtonAdicionarMaterial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAdicionarMaterial);
            this.Controls.Add(this.ButtonRegistrarDevolucion);
            this.Controls.Add(this.ButtonRegistrarPrestamo);
            this.Controls.Add(this.ButtonConsultarHistorial);
            this.Controls.Add(this.ButtonRegistrarMaterial);
            this.Controls.Add(this.ButtonEliminarPersona);
            this.Controls.Add(this.ButtonRegistrarPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRegistrarPersona;
        private System.Windows.Forms.Button ButtonEliminarPersona;
        private System.Windows.Forms.Button ButtonRegistrarMaterial;
        private System.Windows.Forms.Button ButtonConsultarHistorial;
        private System.Windows.Forms.Button ButtonRegistrarPrestamo;
        private System.Windows.Forms.Button ButtonRegistrarDevolucion;
        private System.Windows.Forms.Button ButtonAdicionarMaterial;
    }
}

