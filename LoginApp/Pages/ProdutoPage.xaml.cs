using System;
using Microsoft.Maui.Controls;

namespace LoginApp.Pages
{
    public partial class ProdutoPage : ContentPage
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }

        private async void OnModoDeUsoClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is string produtoNome)
            {
                await Navigation.PushAsync(new ProdutoDetalhesPage(produtoNome));
            }
        }
    }
}
