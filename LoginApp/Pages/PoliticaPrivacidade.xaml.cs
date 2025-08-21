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
            // Navega��o para a p�gina de perfil com os argumentos necess�rios
            await Navigation.PushAsync(new PerfilPage());
        }
        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}




