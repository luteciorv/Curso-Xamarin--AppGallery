using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class MainSideMenu : MasterDetailPage
    {
        public MainSideMenu()
        {
            InitializeComponent();
        }

        // Abrir página de conteúdo
        private void OpenContentPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new XamarinForms.Pages.Content.Content();

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }

        // Abrir página de navegação
        private void OpenNavigationPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new NavigationPage(new XamarinForms.Pages.Navigation.ContentPage01());

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }

        // Abrir página carrossel
        private void OpenCarouselPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new XamarinForms.Pages.Carousel.Carousel();

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }

        // Abrir página de guias
        private void OpenTabbedPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new XamarinForms.Pages.Tabbed.Tabbed();

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }

        // Abrir menu lateral
        private void OpenMasterDetailPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new XamarinForms.Pages.Side_Menu.SideMenu();

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }

        // Abrir modal
        private void OpenModalPage(object sender, EventArgs e)
        {
            // Referência a página principal
            MasterDetailPage mainPage = (MasterDetailPage)Application.Current.MainPage;

            // Instanciar página em questão
            mainPage.Detail = new XamarinForms.Pages.Modal.Content01();

            // Esconder o menu lateral
            mainPage.IsPresented = false;
        }
    }
}