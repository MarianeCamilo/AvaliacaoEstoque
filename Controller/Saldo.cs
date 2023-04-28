using Models;

namespace Controllers
{
    public class Saldo
    {

        public static void criarSaldo(Models.Saldo saldo) {
            Models.Saldo.criarSaldo(saldo);
        }

        public static void listarSaldos() {
            Models.Saldo.listarSaldos();
        }

        public static void alterarSaldos(Models.Saldo saldo) {
            Models.Saldo.alterarSaldo(saldo);
        }

        public static void excluirSaldos(int id) {
            Models.Saldo.ExcluirSaldo(id);
        }
    }
}