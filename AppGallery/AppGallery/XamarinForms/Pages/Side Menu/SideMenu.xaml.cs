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
    [Obsolete]
    public partial class SideMenu : MasterDetailPage
    {
        public SideMenu()
        {
            InitializeComponent();
        }

        // Abrir a página 1
        private void OpenPage01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Content01());
            IsPresented = false;
        }

        // Abrir a página 2
        private void OpenPage02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Content02());
            IsPresented = false;
        }

        // Abrir a página 3
        private void OpenPage03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Content03());
            IsPresented = false;
        }
    }
}