using Microsoft.Maui.Controls;

namespace LoginApp.Pages
{
    public partial class ProdutoDetalhesPage : ContentPage
    {
        public ProdutoDetalhesPage(string produtoNome)
        {
            InitializeComponent();

            lblProdutoNome.Text = produtoNome;

            switch (produtoNome)
            {
                case "Produto 1":
                    imgProduto.Source = "produto1.png";
                    lblModoUso.Text = "Creme facial de uso diário que hidrata profundamente e mantém o equilíbrio natural da pele. Protege contra ressecamento, fortalece a barreira cutânea e garante uma aparência saudável, suave e confortável ao longo do dia.\r\nModo de uso: Aplique sobre a pele limpa e seca do rosto e pescoço, massageando suavemente até completa absorção. Use diariamente, de manhã e à noite, como parte da rotina de cuidados faciais.";
                    break;

                case "Produto 2":
                    imgProduto.Source = "produto2.png";
                    lblModoUso.Text = "Óleo capilar nutritivo indicado para reparar pontas duplas e reduzir o frizz. Proporciona cabelos sedosos, brilhantes e com movimento natural, deixando-os mais fáceis de pentear e com aparência saudável.\r\nModo de uso: Aplique algumas gotas nos cabelos úmidos ou secos, concentrando nas pontas. Pode ser usado diariamente ou antes da finalização dos penteados.";
                    break;

                case "Produto 3":
                    imgProduto.Source = "produto3.png";
                    lblModoUso.Text = "Sérum facial leve, enriquecido com ativos revitalizantes que ajudam a iluminar e uniformizar o tom da pele. Promove um viço natural, reduz sinais de cansaço e confere uma aparência mais radiante e saudável.\r\nModo de uso: Aplique algumas gotas sobre a pele limpa e seca do rosto e pescoço. Massageie suavemente até total absorção. Pode ser usado de manhã e à noite antes do hidratante.";
                    break;

                case "Produto 4":
                    imgProduto.Source = "produto4.png";
                    lblModoUso.Text = "Creme hidratante com extrato natural de coco, que proporciona uma hidratação intensa e prolongada. Deixa a pele suavemente perfumada, macia e revitalizada, com toque aveludado e aparência saudável.\r\nModo de uso: Espalhe uma quantidade generosa sobre a pele limpa e seca, massageando até absorver completamente. Pode ser usado diariamente, especialmente em áreas ressecadas.";
                    break;

                case "Produto 5":
                    imgProduto.Source = "produto5.png";
                    lblModoUso.Text = "Creme corporal de textura rica e aveludada, desenvolvido para nutrir profundamente a pele. Ajuda a proteger contra o ressecamento e as agressões do dia a dia, deixando a pele macia, confortável e com sensação de hidratação duradoura.\r\nModo de uso: Aplique sobre a pele limpa e seca, massageando suavemente até completa absorção. Use diariamente, especialmente após o banho.";
                    break;

                case "Produto 6":
                    imgProduto.Source = "produto6.png";
                    lblModoUso.Text = "Máscara capilar nutritiva especialmente formulada para restaurar cabelos danificados e fragilizados. Proporciona brilho intenso, maciez ao toque e força desde a raiz até as pontas, ajudando a recuperar a saúde natural dos fios.\r\nModo de uso: Aplique nos cabelos limpos e úmidos, massageando mecha a mecha. Deixe agir por 5 a 10 minutos e enxágue completamente. Use 1 a 2 vezes por semana para melhores resultados.";
                    break;

                default:
                    imgProduto.Source = "placeholder.png"; // uma imagem genérica
                    lblModoUso.Text = "Modo de uso não disponível.";
                    break;
            }
        }
    }
}
