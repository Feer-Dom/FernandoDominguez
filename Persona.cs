using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Dominguez
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public Direccion Direccion { get; set; }
        public Contacto Contacto { get; set; }
    }
}
