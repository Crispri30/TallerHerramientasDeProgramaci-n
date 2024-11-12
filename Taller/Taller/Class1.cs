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
            this.Catalogo_lista = new List<Material>();
            this.Persona_lista = new List<Persona>();
            this.Transaccion_lista = new List<Transaccion>();
        }

        public List<Material> Catalogo_lista { get => catalogo_lista; set => catalogo_lista = value; }
        public List<Persona> Persona_lista { get => persona_lista; set => persona_lista = value; }
        public List<Transaccion> Transaccion_lista { get => transaccion_lista; set => transaccion_lista = value; }
        
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
        private TipoRol rol;
        private int material_max_persona;
        private int material_actual_persona;

        public enum TipoRol
        {
            estudiante,
            profesor,
            administrador
        }

        public Persona(int id, string nombre, TipoRol rol, int material_max_persona, int material_actual_persona)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Rol = rol;
            this.Material_actual_persona = material_actual_persona;
            // Define el límite de préstamos según el rol
            switch (rol)
            {
                case TipoRol.estudiante:
                    this.material_max_persona = 5;
                    break;
                case TipoRol.profesor:
                    this.material_max_persona = 3;
                    break;
                case TipoRol.administrador:
                    this.material_max_persona = 1;
                    break;
            }
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public TipoRol Rol { get => rol; set => rol = value; }
        public int Material_max_persona { get => material_max_persona ; set => material_max_persona = value; }
        public int Material_actual_persona { get => material_actual_persona; set => material_actual_persona = value; }
      
    } 

    public class  Transaccion
    {
    //creamos un atributo de tipo transaccion que me va permitir constantes Prestamo, devolucion o adicion
    private string tipo_transaccion;
    private DateTime fecha_transaccion;
    private Persona persona;
    private Material material;

        public Transaccion(string tipo_transaccion, DateTime fecha_transaccion, Persona persona, Material material)
        {
            this.Tipo_transaccion = tipo_transaccion;
            this.Fecha_transaccion = fecha_transaccion;
            this.Persona = persona;
            this.Material = material;
        }

        public string Tipo_transaccion { get => tipo_transaccion; set => tipo_transaccion = value; }
        public DateTime Fecha_transaccion { get => fecha_transaccion; set => fecha_transaccion = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public Material Material { get => material; set => material = value; }
    }
}