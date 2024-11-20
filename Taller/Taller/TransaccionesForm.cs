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
    public partial class TransaccionesForm : Form
    {
        private Biblioteca1 biblioteca;
        private Controller controller;
        public TransaccionesForm(Biblioteca1 biblioteca, Controller controller)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
            this.controller = controller;

        }

        private void ButtonRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CedulaPersona.Text);
                int identificador = int.Parse(Identificador_material.Text);
                DateTime fecha_transaccion = DateTime.Now;

                /*Transaccion transaccion = new Transaccion("Prestamo", fecha_transaccion, id, identificador);*/
                this.controller.Registrar_Prestamo(biblioteca, id, identificador);

                MessageBox.Show("Prestamo registrado");
                this.Close();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CedulaPersona.Text);
                int identificador = int.Parse(Identificador_material.Text);
                DateTime fecha_transaccion = DateTime.Now;

                /*Transaccion transaccion = new Transaccion("Devolucion", fecha_transaccion, id, identificador);*/
                this.controller.Registrar_Devolucion(biblioteca, id, identificador);

                MessageBox.Show("Devolucion registrada");
                this.Close();

            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAdicionarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CedulaPersona.Text);
                int identificador = int.Parse(Identificador_material.Text);
                DateTime fecha_transaccion = DateTime.Now;

                /*Transaccion transaccion = new Transaccion("Adicionar material", fecha_transaccion, id, identificador);*/
                this.controller.Adicionar_Material(biblioteca, id, identificador);
                MessageBox.Show("Material adicionado");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonConsultarHistorial_Click(object sender, EventArgs e)
        {
            controller.Consultar_Historial(biblioteca);
            
        }
    }
}