// Arquivo: LoginApp/Pages/EsqueciSenha.xaml.cs
using System;
using Microsoft.Maui.Controls;

namespace LoginApp.Pages
{
    public partial class EsqueciSenha : ContentPage
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            // Exemplo de a��o ao clicar no bot�o "Enviar"
            DisplayAlert("Recupera��o de Senha", "Instru��es enviadas para o email informado.", "OK");
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            // Exemplo de a��o ao clicar no bot�o "Voltar"
            Navigation.PopAsync();
        }
    }
}
