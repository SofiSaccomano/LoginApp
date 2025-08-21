namespace LoginApp.Pages
{
    public partial class PoliticaPrivacidade : ContentPage
    {
        public PoliticaPrivacidade()
        {
            InitializeComponent();
        }
        private async void PerfilButton_Clicked(object sender, EventArgs e)
        {
            // Navegação para a página de perfil com os argumentos necessários
            await Navigation.PushAsync(new PerfilPage());
        }
        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}




