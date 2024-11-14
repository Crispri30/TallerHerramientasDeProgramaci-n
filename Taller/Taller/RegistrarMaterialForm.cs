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
    public partial class RegistrarMaterialForm : Form
    {
        private Biblioteca1 biblioteca;
        private Controller controller;

        public RegistrarMaterialForm(Biblioteca1 biblioteca,Controller controller)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
            this.controller = controller;
        }

        private void ConfirmarRegistrarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int identificador = int.Parse(IdentificadorLibro.Text);
                string titulo_material = TituloLibro.Text;
                DateTime fecha_registro = DateTime.Now;
                int cantidad_registrada = 0;
                int cantidad_actual = 0;

                Material material = new Material(identificador, titulo_material, fecha_registro, cantidad_registrada, cantidad_actual);
                this.controller.Registrar_Material(material, biblioteca, identificador);
                MessageBox.Show("Material registrado con exito");
                this.Close(); 
            }
            catch(Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }
        }
    }
}
