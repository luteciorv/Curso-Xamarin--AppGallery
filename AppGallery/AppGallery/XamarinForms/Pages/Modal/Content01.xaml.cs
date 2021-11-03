using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Content01 : ContentPage
    {
        public Content01()
        {
            InitializeComponent();
        }

        // Abrir modal
        private void OpenModal(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Modal());
        }
    }
}