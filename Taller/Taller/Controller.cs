using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modelo.Transaccion;

namespace Taller
{
    public class Controller
    {
        public Controller() { }

        //Busquedas por material
        public Material Buscar_material(Biblioteca1 biblioteca, int identificador)
        {
            foreach (Material mat in biblioteca.Catalogo_lista)
            {
                //mat el material
                if(biblioteca.Catalogo_lista != null && mat.Identificador == identificador)
                {
                    return mat;
                }
            }
            return null;
        }
        //buscar persona
        public Persona Buscar_Persona(Biblioteca1 biblioteca, int id)
        {
            foreach(Persona cedula in biblioteca.Persona_lista)
            {
                if(biblioteca.Persona_lista != null && cedula.Id == id)
                {
                    return cedula;
                }
            }
            return null;
        }
        //Registrar persona
        public bool Registrar_Persona(Persona persona, Biblioteca1 biblioteca, int id)
        {
            if (Buscar_Persona(biblioteca, id) != null)
            {
                throw new ArgumentException("Ya existe una persona con este id");
            }
            
            biblioteca.Persona_lista.Add(persona);
            return true;
        }

        //Registrar material
        public bool Registrar_Material(Material material, Biblioteca1 biblioteca, int identificador)
        {

            if (Buscar_material(biblioteca, identificador) != null )
            {
                throw new ArgumentException("Ya existe un material con este identificador");
            }
              
            biblioteca.Catalogo_lista.Add(material);
            material.Cantidad_actual++;
            material.Cantidad_registrada++;
            return true;
        }

        //Eliminar una persona
        public bool Eliminar_Persona(Biblioteca1 biblioteca, int id)
        {
            Persona persona = Buscar_Persona(biblioteca, id);
            if (persona == null)
            {
                throw new ArgumentException("No se encontro a la persona");
            }
            if (persona.Material_actual_persona > 0)
            {
                throw new ArgumentException("No se puede eliminar, la persona tiene materiales prestados");
            }
            else
            {
                biblioteca.Persona_lista.Remove(persona);
                MessageBox.Show("Usuario eliminado con exito");
                return true;
            }
        }

        //Registrar un prestamo

        public bool Registrar_Prestamo(Biblioteca1 biblioteca, int id, int identificador)
        {
            Persona persona = Buscar_Persona(biblioteca, id);
            Material material = Buscar_material(biblioteca, identificador);

            if (persona == null || material == null )
            {
                throw new ArgumentException("Material o persona no encontrados");
            }
            if (material.Cantidad_actual == 0)
            {
                throw new ArgumentException("Cantidad actual del material no disponible");
            }
            if (persona.Material_actual_persona > persona.Material_max_persona)
            {
                throw new ArgumentException("Usuario llego al limite de materiales prestados");
            }
            material.Cantidad_actual--;
            persona.Material_actual_persona++;

            //Crear una nueva variable transaccion con los datos de la persona, material y tipo de transaccion
            Transaccion transaccion = new Transaccion("Prestamo", DateTime.Now, persona, material);
            //Añadir transaccion en la lista
            biblioteca.Transaccion_lista.Add(transaccion);
            return true;
        }

        public bool Registrar_Devolucion(Biblioteca1 biblioteca, int id, int identificador)
        {
            Persona persona = Buscar_Persona(biblioteca, id);
            Material material = Buscar_material(biblioteca, identificador);

            if (persona == null || material == null)
            {
                throw new ArgumentException("Persona o material no encontrado");
            }
            if (persona.Material_actual_persona <= 0)
            {
                throw new ArgumentException("No hay materiales prestados por esta persona");
            }

            material.Cantidad_actual++;
            persona.Material_actual_persona--;

            Transaccion transaccion = new Transaccion("Devolucion", DateTime.Now, persona, material);
            biblioteca.Transaccion_lista.Add(transaccion);
            return true;
        }

        public bool Adicionar_Material(Biblioteca1 biblioteca, int id, int identificador)
        {
            Persona persona = Buscar_Persona(biblioteca, id);
            Material material = Buscar_material(biblioteca, identificador);

            if (persona == null || material == null)
            {
                throw new ArgumentException("Material o persona no encontrados");
            }
            material.Cantidad_actual++;
            material.Cantidad_registrada++;

            Transaccion transaccion = new Transaccion("Adicionar material", DateTime.Now, persona, material);
            biblioteca.Transaccion_lista.Add(transaccion);
            return true;
        }

        public List<Transaccion> Consultar_Historial(Biblioteca1 biblioteca)
        {
            return biblioteca.Transaccion_lista;
        }
    }
}