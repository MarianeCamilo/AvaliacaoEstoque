using Controllers;

namespace Views
{
    public class Menu
    {

        public static void MenuForm() {
            Form menuForm = new Form();
            menuForm.Text = "Menu";
            menuForm.Width = 400;
            menuForm.Height = 350;
            menuForm.StartPosition = FormStartPosition.CenterScreen;
            menuForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            menuForm.MaximizeBox = false;
            menuForm.MinimizeBox = false;
            menuForm.ShowIcon = false;
            menuForm.ShowInTaskbar = false;
            menuForm.TopMost = true;
            menuForm.FormClosed += (sender, e) => { menuForm.Dispose(); };

            Button cadastrarProdutoButton = new Button();
            cadastrarProdutoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarProdutoButton.Text = "Produto";
            cadastrarProdutoButton.Top = 70;
            cadastrarProdutoButton.Left = 65;
            cadastrarProdutoButton.Width = 250;
            cadastrarProdutoButton.Click += (sender, e) =>
            {
                Views.Produto.listarProdutos();
                menuForm.Hide(); 
                menuForm.Close();
                
            };

            Button cadastrarAlmoxarifadoButton = new Button();
            cadastrarAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarAlmoxarifadoButton.Top = 110;
            cadastrarAlmoxarifadoButton.Text = "Almoxarifado";
            cadastrarAlmoxarifadoButton.Left = 65;
            cadastrarAlmoxarifadoButton.Width = 250;
            cadastrarAlmoxarifadoButton.Click += (sender, e) =>
            {
                Views.Almoxarifado.listarAlmoxarifados();
                menuForm.Hide(); 
                menuForm.Close(); 
                
            };

            Button cadastrarSaldoButton = new Button();
            cadastrarSaldoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarSaldoButton.Top = 150;
            cadastrarSaldoButton.Text = "Saldo";
            cadastrarSaldoButton.Left = 65;
            cadastrarSaldoButton.Width = 250;
            cadastrarSaldoButton.Click += (sender, e) =>
            {
                Views.Saldo.listarSaldos();
                menuForm.Hide(); 
                menuForm.Close(); // fecha o formulário atual
                menuForm.Dispose();
            };

            Button sairButton = new Button();
            sairButton.BackColor = System.Drawing.Color.Gray;
            sairButton.Text = "Sair";
            sairButton.Top = 190;
            sairButton.Left = 65;
            sairButton.Width = 250;
            sairButton.Click += (sender, e) => { menuForm.Close(); };
            
            menuForm.Controls.Add(sairButton);
            menuForm.Controls.Add(cadastrarProdutoButton);
            menuForm.Controls.Add(cadastrarAlmoxarifadoButton);
            menuForm.Controls.Add(cadastrarProdutoButton);
            menuForm.Controls.Add(cadastrarSaldoButton);
            menuForm.ShowDialog();
            
        }
    }
}