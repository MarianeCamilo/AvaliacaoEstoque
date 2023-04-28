using Models;

namespace Controllers
{
    public class Almoxarifado
    {

        public static void criarAlmoxarifado(Models.Almoxarifado almoxarifado) {
            Models.Almoxarifado.criarAlmoxarifado(almoxarifado);
        }

        public static void listarAlmoxarifados() {
            Models.Almoxarifado.listarAlmoxarifados();
        }

        public static void alterarAlmoxarifados(Models.Almoxarifado almoxarifado) {
            Models.Almoxarifado.alterarAlmoxarifado(almoxarifado);
        }

        public static void excluirAlmoxarifados(int id) {
            Models.Almoxarifado.ExcluirAlmoxarifado(id);
        }
    }
}