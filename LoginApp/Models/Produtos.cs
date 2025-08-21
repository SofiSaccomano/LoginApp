namespace LoginApp.Models
{
    public class Produtos
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string ModoUso { get; set; }

        public Produtos(string nome, string imagem, string modoUso)
        {
            Nome = nome;
            Imagem = imagem;
            ModoUso = modoUso;
        }
    }
}

