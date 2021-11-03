using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPage03 : ContentPage
    {
        public ContentPage03()
        {
            InitializeComponent();
        }

        // Sobrescrever o método para retornar a tela
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        // Retroceder para a página de conteúdo anterior
        private void BackToPreviousPage(object sender, EventArgs e)
        {
            // Remove a página
            _ = Navigation.PopAsync();
        }

        // Voltar para a página inicial da pilha
        private void BackToBegin(object sender, EventArgs e)
        {
            _ = Navigation.PopToRootAsync();
        }

        // Inserir uma página na pilha
        private void InsertPageOnStack(object sender, EventArgs e)
        {
            // Inserir a página InsertedPage no início da pilha
            Navigation.InsertPageBefore(new InsertedPage(), Navigation.NavigationStack[0]);
        }

        // Remover uma página da pilha
        private void RemovePageFromStack(object sender, EventArgs e)
        {
            // Remover a página InsertedPage do início da pilha
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}