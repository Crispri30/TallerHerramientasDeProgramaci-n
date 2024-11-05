using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Modelo.Transaccion;

namespace Taller
{
    internal class Controller
    {
        public Controller() { }

        //Busquedas por material y por persona
        public Material Buscar_material(Biblioteca1 biblioteca, int identificador)
        {
            foreach (Material mat in biblioteca.Catalogo_lista)
            {
                //m el material
                if(mat.Identificador == identificador)
                {
                    return mat;
                }
            }
            return null;
        }

        public Persona Buscar_Persona(Biblioteca1 biblioteca, int id)
        {
            foreach(Persona cedula in biblioteca.Persona_lista)
            {
                if(cedula.Id == id)
                {
                    return cedula;
                }
            }
            return null;
        }


        //Registrar material
        public bool Registrar_Material(List<Material> catalogo_lista, Material material, Biblioteca1 biblioteca)
        {

            if (Buscar_material(biblioteca, material.Identificador) != null )
            {
                throw new ArgumentException("Ya existe un material con este identificador");
            }
            else
            {
                catalogo_lista.Add(material);
                material.Cantidad_actual++;
                material.Cantidad_registrada++;
                return true;
            }
            

        }
        //Registrar persona
        public bool Registrar_Persona(List<Persona> persona_lista, Persona persona, Biblioteca1 biblioteca)
        {
            if (Buscar_Persona(biblioteca, persona.Id) != null )
            {
                throw new ArgumentException("Ya existe una persona con este id");
            }
            else
            {
                // Usa la propiedad `Rol` de la persona para determinar `Material_max_persona`
                if (persona.Rol == Persona.TipoRol.estudiante)
                {
                    persona.Material_max_persona = 5;
                }
                else if (persona.Rol == Persona.TipoRol.profesor)
                {
                    persona.Material_max_persona = 3;
                }
                else if (persona.Rol == Persona.TipoRol.administrador)
                {
                    persona.Material_max_persona = 1;
                }

            }
            persona_lista.Add(persona);
            return true;
        }

        //Registrar un prestamo

        public void Registrar_Prestamo(Biblioteca1 biblioteca, string tipo_transaccion, Material material, Persona persona)
        {
            Buscar_material(biblioteca, material.Identificador);
            Buscar_Persona(biblioteca, persona.Id);
            if (persona.Rol == Persona.TipoRol.estudiante &&  < 5)

        }
    }
}
