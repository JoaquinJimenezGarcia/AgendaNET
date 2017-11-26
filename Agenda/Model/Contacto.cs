using System;

namespace Agenda.Model
{
    public class Contacto
    {
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Nombre);
        }
    }
}
