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
    public partial class GestionDeUsuarios : Form
    {
        private Biblioteca1 biblioteca;
        private Controller controller;
        public GestionDeUsuarios(Biblioteca1 biblioteca, Controller controller)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
            this.controller = controller;

            //obtener los valores definidos en el enum y mostrarlos en el combo box para que el usuario pueda elegir el rol de la persona
            comboBoxRol.DataSource = Enum.GetValues(typeof(Persona.TipoRol));
        }

        private void RegistrarPersonaForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmarRegistrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                //Guarda en una variable id, nombre y rol la información puesta por el usuario.
                int id = int.Parse(IDPersona.Text);
                string nombre = NombreText.Text;
                var rol = (Persona.TipoRol)comboBoxRol.SelectedItem;
                int material_max_persona = 0;

                //Según el rol seleccionado se asigna el material maximo que puede prestar el usuario
                switch (rol)
                {
                    case Persona.TipoRol.estudiante:
                        material_max_persona = 5;
                        break;
                    case Persona.TipoRol.profesor:
                        material_max_persona = 3;
                        break;
                    case Persona.TipoRol.administrador:
                        material_max_persona = 1;
                        break;
                }
                
                int material_actual_persona = 0;


                Persona persona = new Persona(id, nombre, rol, material_max_persona, material_actual_persona);
                this.controller.Registrar_Persona(persona, biblioteca, id);


                MessageBox.Show("Usuario registrado con exito");
                this.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfirmarEliminarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDPersona.Text);
                this.controller.Eliminar_Persona(biblioteca, id);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
