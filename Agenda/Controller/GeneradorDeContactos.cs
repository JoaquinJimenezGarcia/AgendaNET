using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Agenda.Model;
using System.Text;

namespace Agenda.Controller
{
    public class GeneradorDeContactos
    {
        private static List<string> ListaNombres = new List<string>()
        {
            "Julián", "Joaquin", "Marta", "Maricarmen", "Carmen", "Antonio",
            "Pepe", "Lola", "Victor", "Angel", "Jesus"
        };

        private static List<string> ListaApellidos = new List<string>()
        {
            "Jimenez", "Garcia", "Flores", "De Pablo", "Sanchez", "Rodriguez",
            "Kennedy", "Maestre", "Carmona", "Aragón", "De Giles"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var Random = new Random();
            var Contactos = new ObservableCollection<Contacto>();

            for (int i = 0; i < 25; i++)
            {
                var NombreContacto = ListaNombres[Random.Next(ListaNombres.Count - 1)];
                var ApellidosContacto = ListaApellidos[Random.Next(ListaApellidos.Count - 1)];
                var CalleContacto = ListaNombres[Random.Next(ListaNombres.Count - 1)];
                var Contacto = new Contacto
                {
                    Nombre = NombreContacto + " " + ApellidosContacto,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida " + CalleContacto
                };

                Contactos.Add(Contacto);
            }

            return Contactos;
        }

        private static string GenerarTelefono()
        {
            var Random = new Random();
            StringBuilder Telefono = new StringBuilder();

            Telefono.Append("(");
            Telefono.Append(Random.Next(100,999));
            Telefono.Append(")");
            Telefono.Append(Random.Next(1000000, 99999999));

            return Telefono.ToString();
        }
    }
}
