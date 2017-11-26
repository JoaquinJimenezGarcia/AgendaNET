using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Agenda.Controller;

namespace Agenda.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            btnVerContactos.Clicked += (sender, e) => 
            {
                Navigation.PushAsync(new PaginaListaContactos());
            };
        }
    }
}
