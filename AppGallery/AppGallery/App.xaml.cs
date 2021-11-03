using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*
            // Instanciar página de navegação
            NavigationPage page = new NavigationPage(new XamarinForms.Pages.Navigation.ContentPage01());

            // Atribuir página inicial
            MainPage = page;
            */

            MainPage = new XamarinForms.Pages.Modal.Content01();
        }

        // Aplicação iniciada
        protected override void OnStart()
        {
        }

        // Sai do aplicativo, mas ele continua aberto em segundo plano
        protected override void OnSleep()
        {
        }

        // Retorna ao aplicativo
        protected override void OnResume()
        {
        }
    }
}
