using LoginApp.Models;

namespace LoginApp.Pages
{

    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();

            if (App.Usuario != null)
            {
                this.BindingContext = App.Usuario;
            }
            else
            {
                // Se não tiver na memória, tenta buscar do banco ou SecureStorage
                CarregarUsuario();
            }
        }

        private async void CarregarUsuario()
        {
            var usuarios = await App.BancoDados.UsuarioDataTable.GetUsuariosAsync();
            var ultimo = usuarios.LastOrDefault();

            if (ultimo != null)
            {
                App.Usuario = ultimo;
                this.BindingContext = ultimo;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginUsuarioPage());
        }

        private async void ButtonHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }

}