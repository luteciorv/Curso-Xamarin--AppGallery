using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPage02 : ContentPage
    {
        public ContentPage02()
        {
            InitializeComponent();
        }
        
        // Avançar para a página de conteúdo 03
        private void OpenContentPage03(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new ContentPage03());
        }

        // Retroceder para a página de conteúdo anterior
        private void BackToPreviousPage(object sender, EventArgs e)
        {
            // Remove a página
            _ = Navigation.PopAsync();
        }
    }
}