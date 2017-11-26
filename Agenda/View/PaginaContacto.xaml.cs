using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Agenda.Model;

namespace Agenda.View
{
    public partial class PaginaContacto : ContentPage
    {
        public PaginaContacto(Contacto Contacto)
        {
            InitializeComponent();
            BackgroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = Contacto;
        }
    }
}
