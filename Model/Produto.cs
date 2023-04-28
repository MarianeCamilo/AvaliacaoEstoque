using System;

namespace Models
{
    public class Produto
    {
        public int id;
        public string nome;
        public float preco;

        public static List<Produto> produtos = new List<Produto>();

        public Produto(int id, string nome, float preco) {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }

        public static void criarProduto(Produto produto) {
            produtos.Add(produto);
        }

        public static void listarProdutos() {
            foreach(Produto produto in produtos) {
                Console.WriteLine("Id: " + produto.id + "Nome: " + produto.nome + "Preço: " + produto.preco);
            }
        }

       public static void alterarProduto(Produto produto)
        {
            int index = produtos.FindIndex(p => p.id == produto.id);
            if (index != -1)
            {
                produtos[index] = produto;
            }
        }

       public static void ExcluirProduto(int Id)
        {
            Produto produto = produtos.Find(p => p.id == Id);
            if (produto != null)
            {
                produtos.Remove(produto);
            }
        }
    }
}