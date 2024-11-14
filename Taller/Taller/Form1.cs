﻿using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class Form1 : Form
    {
        private Biblioteca1 biblioteca;
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca1(new List<Material>(), new List<Persona>(), new List<Transaccion>());
            controller = new Controller();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRegistrarPersona_Click(object sender, EventArgs e)
        {
            
            RegistrarPersonaForm registrarpersonaForm = new RegistrarPersonaForm(biblioteca, controller);
            //abrir el form de registrar persona y almacenar los datos en la var registrarpersonaForm
            registrarpersonaForm.ShowDialog();
        }

        private void ButtonRegistrarMaterial_Click(object sender, EventArgs e)
        {
            RegistrarMaterialForm registrarmaterialForm = new RegistrarMaterialForm(biblioteca, controller);
            registrarmaterialForm.ShowDialog();
        }
    }
}
