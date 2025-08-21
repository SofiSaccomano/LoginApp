using Microsoft.Maui.Controls;

namespace LoginApp.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }



        // Updated constructor call with required parameters
        private async void PerfilButton_Clicked(object sender, EventArgs e)
        {
            // Navega��o para a p�gina de perfil com os argumentos necess�rios
            await Navigation.PushAsync(new PerfilPage());
        }

        // Evento do bot�o "CONHE�A NOSSAS DICAS"
        private async void ConhecaDicasButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutoPage());
        }

        private async void PoliticaPrivacidade_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PoliticaPrivacidade());
        }
    }
}