using Modelo;
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
        public Form1()
        {
            InitializeComponent();
            this.biblioteca = new Biblioteca1(new List<Material>(), new List<Persona>(), new List<Transaccion>());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
