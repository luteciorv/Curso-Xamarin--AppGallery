using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertedPage : ContentPage
    {
        public InsertedPage()
        {
            InitializeComponent();
        }

        // Abrir a página inicial
        private void Home(object sender, EventArgs e)
        {
            // Instanciar uma nova página inicial (Limpa o histórico)
            Application.Current.MainPage = new NavigationPage(new ContentPage01());
        }
    }
}