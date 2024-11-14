namespace Taller
{
    partial class RegistrarPersonaForm
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
            this.SuspendLayout();
            // 
            // ConfirmarRegistrarPersona
            // 
            this.ConfirmarRegistrarPersona.Location = new System.Drawing.Point(565, 209);
            this.ConfirmarRegistrarPersona.Name = "ConfirmarRegistrarPersona";
            this.ConfirmarRegistrarPersona.Size = new System.Drawing.Size(104, 42);
            this.ConfirmarRegistrarPersona.TabIndex = 0;
            this.ConfirmarRegistrarPersona.Text = "Confirmar";
            this.ConfirmarRegistrarPersona.UseVisualStyleBackColor = true;
            this.ConfirmarRegistrarPersona.Click += new System.EventHandler(this.ConfirmarRegistrarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(372, 144);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol";
            // 
            // IDPersona
            // 
            this.IDPersona.Location = new System.Drawing.Point(382, 70);
            this.IDPersona.Name = "IDPersona";
            this.IDPersona.Size = new System.Drawing.Size(100, 20);
            this.IDPersona.TabIndex = 5;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(382, 104);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(100, 20);
            this.NombreText.TabIndex = 6;
            // 
            // RegistrarPersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.IDPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarRegistrarPersona);
            this.Name = "RegistrarPersonaForm";
            this.Text = "RegistrarPersonaForm";
            this.Load += new System.EventHandler(this.RegistrarPersonaForm_Load);
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
    }
}