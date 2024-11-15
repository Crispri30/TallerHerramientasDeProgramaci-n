namespace Taller
{
    partial class GestionDeUsuarios
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
            this.ConfirmarRegistrarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDPersona = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.ConfirmarEliminarPersona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmarRegistrarPersona
            // 
            this.ConfirmarRegistrarPersona.Location = new System.Drawing.Point(238, 294);
            this.ConfirmarRegistrarPersona.Name = "ConfirmarRegistrarPersona";
            this.ConfirmarRegistrarPersona.Size = new System.Drawing.Size(104, 42);
            this.ConfirmarRegistrarPersona.TabIndex = 0;
            this.ConfirmarRegistrarPersona.Text = "Registrar persona";
            this.ConfirmarRegistrarPersona.UseVisualStyleBackColor = true;
            this.ConfirmarRegistrarPersona.Click += new System.EventHandler(this.ConfirmarRegistrarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(382, 239);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol";
            // 
            // IDPersona
            // 
            this.IDPersona.Location = new System.Drawing.Point(392, 158);
            this.IDPersona.Name = "IDPersona";
            this.IDPersona.Size = new System.Drawing.Size(100, 20);
            this.IDPersona.TabIndex = 5;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(392, 196);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(100, 20);
            this.NombreText.TabIndex = 6;
            // 
            // ConfirmarEliminarPersona
            // 
            this.ConfirmarEliminarPersona.Location = new System.Drawing.Point(465, 294);
            this.ConfirmarEliminarPersona.Name = "ConfirmarEliminarPersona";
            this.ConfirmarEliminarPersona.Size = new System.Drawing.Size(113, 41);
            this.ConfirmarEliminarPersona.TabIndex = 7;
            this.ConfirmarEliminarPersona.Text = "Eliminar persona";
            this.ConfirmarEliminarPersona.UseVisualStyleBackColor = true;
            this.ConfirmarEliminarPersona.Click += new System.EventHandler(this.ConfirmarEliminarPersona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bienvenido a gestión de personal de biblioteca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "1. Para ingresar una nueva persona por favor digite todos los campos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "2. Para eliminar una persona por favor digite únicamente el campo de cédula";
            // 
            // RegistrarPersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmarEliminarPersona);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.IDPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarRegistrarPersona);
            this.Name = "RegistrarPersonaForm";
            this.Text = "RegistrarPersonaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarRegistrarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDPersona;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Button ConfirmarEliminarPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}