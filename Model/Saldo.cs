using System;

namespace Models
{
    public class Saldo
    {
        public int id;
        public int ProdutoId;
        public int AlmoxarifadoId;
        public int quantidade;

        public static List<Saldo> saldos = new List<Saldo>();

        public Saldo(int id, int ProdutoId, int AlmoxarifadoId, int quantidade) {
            this.id = id;
            this.ProdutoId = ProdutoId;
            this.AlmoxarifadoId = AlmoxarifadoId;
            this.quantidade = quantidade;
        }

        public static void criarSaldo(Saldo saldo) {
            saldos.Add(saldo);
        }

        public static void listarSaldos() {
            foreach(Saldo saldo in saldos) {
                Console.WriteLine("Id: " + saldo.id + "Id Produto: " + saldo.ProdutoId + "Id Almoxarifado: " + saldo.AlmoxarifadoId + "Quantidade: " + saldo.quantidade);
            }
        }

       public static void alterarSaldo(Saldo saldo)
        {
            int index = saldos.FindIndex(p => p.id == saldo.id);
            if (index != -1)
            {
                saldos[index] = saldo;
            }
        }

       public static void ExcluirSaldo(int Id)
        {
            Saldo saldo = saldos.Find(p => p.id == Id);
            if (saldo != null)
            {
                saldos.Remove(saldo);
            }
        }
    }
}