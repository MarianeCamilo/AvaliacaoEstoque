using System;

namespace Models
{
    public class Almoxarifado
    {
        public int id;
        public string nome;

        public static List<Almoxarifado> almoxarifados = new List<Almoxarifado>();

        public Almoxarifado(int id, string nome) {
            this.id = id;
            this.nome = nome;
        }

        public static void criarAlmoxarifado(Almoxarifado almoxarifado) {
            almoxarifados.Add(almoxarifado);
        }

        public static void listarAlmoxarifados() {
            foreach(Almoxarifado almoxarifado in almoxarifados) {
                Console.WriteLine("Id: " + almoxarifado.id + "Nome: " + almoxarifado.nome);
            }
        }

       public static void alterarAlmoxarifado(Almoxarifado almoxarifado)
        {
            int index = almoxarifados.FindIndex(p => p.id == almoxarifado.id);
            if (index != -1)
            {
                almoxarifados[index] = almoxarifado;
            }
        }

       public static void ExcluirAlmoxarifado(int Id)
        {
            Almoxarifado almoxarifado = almoxarifados.Find(p => p.id == Id);
            if (almoxarifado != null)
            {
                almoxarifados.Remove(almoxarifado);
            }
        }
    }
}