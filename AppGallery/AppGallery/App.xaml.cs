using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        [System.Obsolete]
        public App()
        {
            InitializeComponent();

            // NavigationPage();

            // ModalPage();

            // CarouselPage();

            // TabbedPage();

            // SideMenu();

            MainPage = new AppBase.MainSideMenu();
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

        // Página de navegação
        private void NavigationPage()
        {
            // Instanciar página de navegação
            NavigationPage page = new NavigationPage(new XamarinForms.Pages.Navigation.ContentPage01());

            // Atribuir página inicial
            MainPage = page;
        }

        // Modal
        private void ModalPage()
        {
            MainPage = new XamarinForms.Pages.Modal.Content01();
        }

        // Página de carrossel
        private void CarouselPage()
        {
            CarouselPage page = new CarouselPage();

            page.Children.Add(new XamarinForms.Pages.Carousel.Content01());
            page.Children.Add(new XamarinForms.Pages.Carousel.Content02());
            page.Children.Add(new XamarinForms.Pages.Carousel.Content03());

            page.CurrentPage = page.Children[1];

            MainPage = page;
        }

        // Página de guias
        private void TabbedPage()
        {
            MainPage = new XamarinForms.Pages.Tabbed.Tabbed();
        }

        // Menu lateral
        [System.Obsolete]
        private void SideMenu()
        {
            MasterDetailPage page = new MasterDetailPage();

            // Menu
            // page.Master = ;

            // Conteúdo
            // page.Detail = ;

            MainPage = new XamarinForms.Pages.Side_Menu.SideMenu();
        }
    }
}
