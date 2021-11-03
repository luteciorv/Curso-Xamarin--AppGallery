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

            /*//Página Modal
            MainPage = new XamarinForms.Pages.Modal.Content01();
            */

            //Página carrosel
            CarouselPage page = new CarouselPage();

            page.Children.Add(new XamarinForms.Pages.Carousel.Content01());
            page.Children.Add(new XamarinForms.Pages.Carousel.Content02());
            page.Children.Add(new XamarinForms.Pages.Carousel.Content03());

            page.CurrentPage = page.Children[1];

            MainPage = page;            
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
