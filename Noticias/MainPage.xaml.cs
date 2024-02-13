using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Noticias
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="Admin" && txtcontraseña.Text=="123")
            {
                Navigation.PushAsync(new NoticiasPrincipal());
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña incorrectas!", "OK");
            } 
        }
    }
}
