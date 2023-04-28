using Models;

namespace Controllers
{
    public class Produto
    {

        public static void criarProduto(Models.Produto produto) {
            Models.Produto.criarProduto(produto);
        }

        public static void listarProdutos() {
            Models.Produto.listarProdutos();
        }

        public static void alterarProdutos(Models.Produto produto) {
            Models.Produto.alterarProduto(produto);
        }

        public static void excluirProdutos(int id) {
            Models.Produto.ExcluirProduto(id);
        }
    }
}