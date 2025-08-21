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
            // Exemplo de ação ao clicar no botão "Enviar"
            DisplayAlert("Recuperação de Senha", "Instruções enviadas para o email informado.", "OK");
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            // Exemplo de ação ao clicar no botão "Voltar"
            Navigation.PopAsync();
        }
    }
}
