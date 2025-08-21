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
                    lblModoUso.Text = "Creme facial de uso di�rio que hidrata profundamente e mant�m o equil�brio natural da pele. Protege contra ressecamento, fortalece a barreira cut�nea e garante uma apar�ncia saud�vel, suave e confort�vel ao longo do dia.\r\nModo de uso: Aplique sobre a pele limpa e seca do rosto e pesco�o, massageando suavemente at� completa absor��o. Use diariamente, de manh� e � noite, como parte da rotina de cuidados faciais.";
                    break;

                case "Produto 2":
                    imgProduto.Source = "produto2.png";
                    lblModoUso.Text = "�leo capilar nutritivo indicado para reparar pontas duplas e reduzir o frizz. Proporciona cabelos sedosos, brilhantes e com movimento natural, deixando-os mais f�ceis de pentear e com apar�ncia saud�vel.\r\nModo de uso: Aplique algumas gotas nos cabelos �midos ou secos, concentrando nas pontas. Pode ser usado diariamente ou antes da finaliza��o dos penteados.";
                    break;

                case "Produto 3":
                    imgProduto.Source = "produto3.png";
                    lblModoUso.Text = "S�rum facial leve, enriquecido com ativos revitalizantes que ajudam a iluminar e uniformizar o tom da pele. Promove um vi�o natural, reduz sinais de cansa�o e confere uma apar�ncia mais radiante e saud�vel.\r\nModo de uso: Aplique algumas gotas sobre a pele limpa e seca do rosto e pesco�o. Massageie suavemente at� total absor��o. Pode ser usado de manh� e � noite antes do hidratante.";
                    break;

                case "Produto 4":
                    imgProduto.Source = "produto4.png";
                    lblModoUso.Text = "Creme hidratante com extrato natural de coco, que proporciona uma hidrata��o intensa e prolongada. Deixa a pele suavemente perfumada, macia e revitalizada, com toque aveludado e apar�ncia saud�vel.\r\nModo de uso: Espalhe uma quantidade generosa sobre a pele limpa e seca, massageando at� absorver completamente. Pode ser usado diariamente, especialmente em �reas ressecadas.";
                    break;

                case "Produto 5":
                    imgProduto.Source = "produto5.png";
                    lblModoUso.Text = "Creme corporal de textura rica e aveludada, desenvolvido para nutrir profundamente a pele. Ajuda a proteger contra o ressecamento e as agress�es do dia a dia, deixando a pele macia, confort�vel e com sensa��o de hidrata��o duradoura.\r\nModo de uso: Aplique sobre a pele limpa e seca, massageando suavemente at� completa absor��o. Use diariamente, especialmente ap�s o banho.";
                    break;

                case "Produto 6":
                    imgProduto.Source = "produto6.png";
                    lblModoUso.Text = "M�scara capilar nutritiva especialmente formulada para restaurar cabelos danificados e fragilizados. Proporciona brilho intenso, maciez ao toque e for�a desde a raiz at� as pontas, ajudando a recuperar a sa�de natural dos fios.\r\nModo de uso: Aplique nos cabelos limpos e �midos, massageando mecha a mecha. Deixe agir por 5 a 10 minutos e enx�gue completamente. Use 1 a 2 vezes por semana para melhores resultados.";
                    break;

                default:
                    imgProduto.Source = "placeholder.png"; // uma imagem gen�rica
                    lblModoUso.Text = "Modo de uso n�o dispon�vel.";
                    break;
            }
        }
    }
}
