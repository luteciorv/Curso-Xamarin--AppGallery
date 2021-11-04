using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Side_Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Content01 : ContentPage
    {
        public Content01()
        {
            InitializeComponent();
        }

        // Abrir menu lateral
        [Obsolete]
        private void OpenSideMenu(object sender, EventArgs e)
        {
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = true;
        }
    }
}