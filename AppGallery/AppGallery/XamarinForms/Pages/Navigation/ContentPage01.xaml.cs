using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPage01 : ContentPage
    {
        public ContentPage01()
        {
            InitializeComponent();
        }

        private void OpenContentPage02(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new ContentPage02());
        }
    }
}