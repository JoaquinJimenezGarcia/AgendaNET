using System;
using Xamarin.Forms;
using System.Linq;
using Agenda.View;
using Agenda.Model;

namespace Agenda.Controller
{
    public class PaginaListaContactos : MasterDetailPage
    {
        public PaginaListaContactos()
        {
            var Lista = new ListView();

            Lista.ItemsSource = GeneradorDeContactos.CrearContactos().OrderBy(x => x.Nombre);
            Lista.ItemSelected += (sender, e) => {
                if (e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = Lista
            };

            Detail = new PaginaContacto(GeneradorDeContactos.CrearContactos().First());
        }
    }
}
