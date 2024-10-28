using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Biblioteca1
    {
        //Atributos de la clase biblioteca
        public int Identificador;
        public string Titulo_material;
        public DateTime Fecha_registro;
        public int Cantidad_registrada;
        public int Cantidad_actual;

        //Métodos

        public void Prestamo()
        {

        }
    }

    public class Persona
    {
        public int Id;
        public string Nombre;
        public string Rol;

    }
}
