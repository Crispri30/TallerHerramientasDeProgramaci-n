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
            this.ButtonGestionUsuarios = new System.Windows.Forms.Button();
            this.ButtonRegistrarMaterial = new System.Windows.Forms.Button();
            this.ButtonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonGestionUsuarios
            // 
            this.ButtonGestionUsuarios.Location = new System.Drawing.Point(125, 191);
            this.ButtonGestionUsuarios.Name = "ButtonGestionUsuarios";
            this.ButtonGestionUsuarios.Size = new System.Drawing.Size(108, 33);
            this.ButtonGestionUsuarios.TabIndex = 0;
            this.ButtonGestionUsuarios.Text = "Gestión de usuarios";
            this.ButtonGestionUsuarios.UseVisualStyleBackColor = true;
            this.ButtonGestionUsuarios.Click += new System.EventHandler(this.ButtonGestionUsuarios_Click);
            // 
            // ButtonRegistrarMaterial
            // 
            this.ButtonRegistrarMaterial.Location = new System.Drawing.Point(330, 182);
            this.ButtonRegistrarMaterial.Name = "ButtonRegistrarMaterial";
            this.ButtonRegistrarMaterial.Size = new System.Drawing.Size(103, 42);
            this.ButtonRegistrarMaterial.TabIndex = 2;
            this.ButtonRegistrarMaterial.Text = "Registrar material";
            this.ButtonRegistrarMaterial.UseVisualStyleBackColor = true;
            this.ButtonRegistrarMaterial.Click += new System.EventHandler(this.ButtonRegistrarMaterial_Click);
            // 
            // ButtonRegistrarPrestamo
            // 
            this.ButtonRegistrarPrestamo.Location = new System.Drawing.Point(565, 182);
            this.ButtonRegistrarPrestamo.Name = "ButtonRegistrarPrestamo";
            this.ButtonRegistrarPrestamo.Size = new System.Drawing.Size(108, 33);
            this.ButtonRegistrarPrestamo.TabIndex = 4;
            this.ButtonRegistrarPrestamo.Text = "Transacciones";
            this.ButtonRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.ButtonRegistrarPrestamo.Click += new System.EventHandler(this.ButtonRegistrarPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido a gestión de biblioteca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Por favor seleccione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Para agregar o eliminar usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Para agregar material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Para solicitar préstamo, devolución o adicionar material";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRegistrarPrestamo);
            this.Controls.Add(this.ButtonRegistrarMaterial);
            this.Controls.Add(this.ButtonGestionUsuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGestionUsuarios;
        private System.Windows.Forms.Button ButtonRegistrarMaterial;
        private System.Windows.Forms.Button ButtonRegistrarPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

