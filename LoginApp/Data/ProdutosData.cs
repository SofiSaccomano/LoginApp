using System.Collections.Generic;
using LoginApp.Models;

namespace LoginApp.Data
{
    public static class ProdutosData
    {
        public static List<Produtos> ListaProdutos = new List<Produtos>
        {
            new Produtos("Anni Burn – Hair Revival Mask", "produto1.png", "Máscara capilar nutritiva ..."),
            new Produtos("Terra Essenza – Creme Nutritivo", "produto2.png", "Creme corporal rico ..."),
            new Produtos("Coconut Bliss – Creme Hidratante", "produto3.png", "Creme hidratante com coco ..."),
            new Produtos("Rose Glow – Sérum Iluminador", "produto4.png", "Sérum facial leve ..."),
            new Produtos("Golden Drop – Óleo Capilar", "produto5.png", "Óleo nutritivo que repara ..."),
            new Produtos("Pure Balance – Creme Facial Hidratante", "produto6.png", "Creme facial de uso diário ...")
        };
    }
}
