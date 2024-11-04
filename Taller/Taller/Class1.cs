using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modelo.Transaccion;

namespace Modelo
{
    public class Biblioteca1
    {
        private List<Material> catalogo_lista;
        private List<Persona> persona_lista;
        private List<Transaccion> transaccion_lista;

        public Biblioteca1(List<Material> catalogo_lista, List<Persona> persona_lista, List<Transaccion> transaccion_lista)
        {
            this.Catalogo_lista = catalogo_lista;
            this.Persona_lista = persona_lista;
            this.Transaccion_lista = transaccion_lista;
        }

        public List<Material> Catalogo_lista { get => catalogo_lista; set => catalogo_lista = value; }
        public List<Persona> Persona_lista { get => persona_lista; set => persona_lista = value; }
        public List<Transaccion> Transaccion_lista { get => transaccion_lista; set => transaccion_lista = value; }


        //metodos de la clase biblioteca1
        //Registrar material
        public bool Registrar_Material(List<Material> catalogo_lista, Material material) {

            if (catalogo_lista.Any(m => m.Identificador == material.Identificador)) {
                throw new ArgumentException("Ya existe un material con este identificador");
            }
            catalogo_lista.Add(material);
            return true;
        }
        //Registrar persona
        public bool Registrar_Persona( List<Persona> persona_lista, Persona persona)
        {
            if (persona_lista.Any(m => m.Id == persona.Id)){
                throw new ArgumentException("Ya existe una persona con este id");
            }
            persona_lista.Add(persona);
            return true;
        }
        //Registrar un prestamo

        public bool Registrar_Prestamo( List<Transaccion> transaccion_lista, TipoTransaccion tipo_Transaccion, List<Persona> persona_lista, Persona persona, Material material)
        {

        }

        
    }

    

    public class Material
    {
    //Atributos de la clase material
    private int identificador;
    private string titulo_material;
    private DateTime fecha_registro;
    private int cantidad_registrada;
    private int cantidad_actual;

        public Material(int identificador, string titulo_material, DateTime fecha_registro, int cantidad_registrada, int cantidad_actual)
        {
            this.Identificador = identificador;
            this.Titulo_material = titulo_material;
            this.Fecha_registro = fecha_registro;
            this.Cantidad_registrada = cantidad_registrada;
            this.Cantidad_actual = cantidad_actual;
        }

        //metodos de la clase material
        public int Identificador { get => identificador; set => identificador = value; }
        public string Titulo_material { get => titulo_material; set => titulo_material = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public int Cantidad_registrada { get => cantidad_registrada; set => cantidad_registrada = value; }
        public int Cantidad_actual { get => cantidad_actual; set => cantidad_actual = value; }
    }

    public class Persona
    {
        private int id;
        private string nombre;
        //Creamos un atributo rol de tipo rol, para poder elegir entre estudiante, profesor y administrador
        private Rol rol;

        public enum Rol
        {
            Estudiante,
            Profesor,
            Administrador
        }

        public Persona(int id, string nombre, Rol rol)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Rol1 = rol;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Rol Rol1 { get => rol; set => rol = value; }
      
    } 

    public class  Transaccion
    {
    //creamos un atributo de tipo transaccion que me va permitir constantes Prestamo, devolucion o adicion
    public TipoTransaccion tipo_transaccion;
    private DateTime fecha_transaccion;
    private Persona persona;
    private Material material;
    public enum TipoTransaccion
    {
        Prestamo,
        Devolucion,
        Adicion
    }
    public Transaccion(TipoTransaccion tipo_transaccion, DateTime fecha_transaccion, Persona persona, Material material)
    {
        this.Tipo_transaccion = tipo_transaccion;
        this.Fecha_transaccion = fecha_transaccion;
        this.Persona = persona;
        this.Material = material;
    }

    public TipoTransaccion Tipo_transaccion { get => tipo_transaccion; set => tipo_transaccion = value; }
    public DateTime Fecha_transaccion { get => fecha_transaccion; set => fecha_transaccion = value; }
    public Persona Persona { get => persona; set => persona = value; }
    public Material Material { get => material; set => material = value; }
    
    }
}
