using Controllers;

namespace Views
{
    public class Saldo
    {
        public static void listarSaldos() {
            Form form = new Form();
            form.Text = "Saldos";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => { form.Dispose(); };
            
            ListView lista = new ListView();
            lista.Location = new System.Drawing.Point(10, 10);
            lista.Size = new System.Drawing.Size(480, 350);
            lista.View = View.Details;
           
            lista.Columns.Add("Id");
            lista.Columns.Add("Id Produto");
            lista.Columns.Add("Id Almoxarifado");
            lista.Columns.Add("Quantidade");

           foreach(Models.Saldo saldo in Models.Saldo.saldos) {
                lista.Items.Add(new ListViewItem(new string[] {saldo.id.ToString(), saldo.ProdutoId.ToString(), saldo.AlmoxarifadoId.ToString(), saldo.quantidade.ToString()}));
            }
            
            Button cadastrarSaldoButton = new Button();
            cadastrarSaldoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarSaldoButton.Text = "Adicionar";
            cadastrarSaldoButton.Top = 360;
            cadastrarSaldoButton.Left = 10;
            cadastrarSaldoButton.Width = 70;
            cadastrarSaldoButton.Click += (sender, e) => { Views.Saldo.addSaldo();
            
                form.Close(); 
                form.Dispose();
            };

            Button alterarSaldoButton = new Button();
            alterarSaldoButton.BackColor = System.Drawing.Color.Gray;
            alterarSaldoButton.Text = "Alterar";
            alterarSaldoButton.Top = 360;
            alterarSaldoButton.Left = 90;
            alterarSaldoButton.Width = 60;
            alterarSaldoButton.Click += (sender, e) => {Views.Saldo.alterarSaldo();
            
                form.Close(); 
                form.Dispose();
            };

            Button excluirButton = new Button();
            excluirButton.BackColor = System.Drawing.Color.Gray;
            excluirButton.Text = "Excluir";
            excluirButton.Top = 360;
            excluirButton.Left = 160;
            excluirButton.Width = 60;
            excluirButton.Click += (sender, e) => { Views.Saldo.excluirSaldo();
            
                form.Close(); 
                form.Dispose();
            };

            Button SairSaldoButton = new Button();
            SairSaldoButton.BackColor = System.Drawing.Color.Gray;
            SairSaldoButton.Text = "Sair";
            SairSaldoButton.Top = 360;
            SairSaldoButton.Left = 230;
            SairSaldoButton.Width = 60;
            SairSaldoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(cadastrarSaldoButton);
            form.Controls.Add(alterarSaldoButton);
            form.Controls.Add(excluirButton);
            form.Controls.Add(SairSaldoButton);
            form.Controls.Add(lista);
            form.Controls.Add(lista);
            form.ShowDialog();

        }

        public static void addSaldo (){
            
            int id = Models.Saldo.saldos.Count + 1;

            Form form = new Form();
            form.Text = "Saldos";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => { form.Dispose(); };

            Label labelCadastrar = new Label();
            labelCadastrar.Text = "Cadastrar saldo";
            labelCadastrar.Top = 10;
            labelCadastrar.Left = 200;
            labelCadastrar.Width = 300;
     
            Label labelSaldo = new Label();
            labelSaldo.Text = "Id Saldo:";
            labelSaldo.Location = new Point(80, 90);
            labelSaldo.AutoSize = true;
            form.Controls.Add(labelSaldo);

            TextBox texto_1 = new TextBox();
            texto_1.Top = 110;
            texto_1.Left = 80;
            texto_1.Width = 300;
                        
            Label labelProduto = new Label();
            labelProduto.Text = "Id Produto:";
            labelProduto.Location = new Point(80, 140);
            labelProduto.AutoSize = true;
            form.Controls.Add(labelProduto);

            TextBox texto_2 = new TextBox();
            texto_2.Top = 160;
            texto_2.Left = 80;
            texto_2.Width = 300;

            Label labelAlmoxarifado = new Label();
            labelAlmoxarifado.Text = "Id Almoxarifado:";
            labelAlmoxarifado.Location = new Point(80, 190);
            labelAlmoxarifado.AutoSize = true;
            form.Controls.Add(labelAlmoxarifado);

            TextBox texto_3 = new TextBox();
            texto_3.Top = 210;
            texto_3.Left = 80;
            texto_3.Width = 300;

            Label labelQuantidade = new Label();
            labelQuantidade.Text = "Quantidade:";
            labelQuantidade.Location = new Point(80, 240);
            labelQuantidade.AutoSize = true;
            form.Controls.Add(labelQuantidade);

            TextBox texto_4 = new TextBox();
            texto_4.Top = 260;
            texto_4.Left = 80;
            texto_4.Width = 300;

            Button CadastraSaldoButton = new Button();
            CadastraSaldoButton.BackColor = System.Drawing.Color.Gray;
            CadastraSaldoButton.Text = "Cadastrar";
            CadastraSaldoButton.Top = 360;
            CadastraSaldoButton.Left = 220;
            CadastraSaldoButton.Width = 70;
            CadastraSaldoButton.Click += (sender, e) => { 
                Controllers.Saldo.criarSaldo(new Models.Saldo(id, int.Parse(texto_2.Text), int.Parse(texto_3.Text), int.Parse(texto_4.Text))); 
                form.Close();
                form.Dispose();
                Views.Saldo.listarSaldos();
                };

            Button SairSaldoButton = new Button();
            SairSaldoButton.BackColor = System.Drawing.Color.Gray;
            SairSaldoButton.Text = "Sair";
            SairSaldoButton.Top = 360;
            SairSaldoButton.Left = 300;
            SairSaldoButton.Width = 60;
            SairSaldoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };


            form.Controls.Add(texto_1);
            form.Controls.Add(texto_2);
            form.Controls.Add(texto_3);
            form.Controls.Add(texto_4);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(SairSaldoButton);
            form.Controls.Add(CadastraSaldoButton);
            form.ShowDialog();
        }

        public static void alterarSaldo (){
            
            int id = Models.Saldo.saldos.Count + 1;

            Form form = new Form();
            form.Text = "Saldos";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => { form.Dispose(); };

            Label labelCadastrar = new Label();
            labelCadastrar.Text = "Alterar Saldo";
            labelCadastrar.Top = 10;
            labelCadastrar.Left = 200;
            labelCadastrar.Width = 300;

            Label labelSaldo = new Label();
            labelSaldo.Text = "Id Saldo:";
            labelSaldo.Location = new Point(80, 90);
            labelSaldo.AutoSize = true;
            form.Controls.Add(labelSaldo);

            TextBox texto_1 = new TextBox();
            texto_1.Top = 110;
            texto_1.Left = 80;
            texto_1.Width = 300;
                        
            Label labelProduto = new Label();
            labelProduto.Text = "Id Produto:";
            labelProduto.Location = new Point(80, 140);
            labelProduto.AutoSize = true;
            form.Controls.Add(labelProduto);

            TextBox texto_2 = new TextBox();
            texto_2.Top = 160;
            texto_2.Left = 80;
            texto_2.Width = 300;

            Label labelAlmoxarifado = new Label();
            labelAlmoxarifado.Text = "Id Almoxarifado:";
            labelAlmoxarifado.Location = new Point(80, 190);
            labelAlmoxarifado.AutoSize = true;
            form.Controls.Add(labelAlmoxarifado);

            TextBox texto_3 = new TextBox();
            texto_3.Top = 210;
            texto_3.Left = 80;
            texto_3.Width = 300;

            Label labelQuantidade = new Label();
            labelQuantidade.Text = "Quantidade:";
            labelQuantidade.Location = new Point(80, 240);
            labelQuantidade.AutoSize = true;
            form.Controls.Add(labelQuantidade);

            TextBox texto_4 = new TextBox();
            texto_4.Top = 260;
            texto_4.Left = 80;
            texto_4.Width = 300;
         
            Button CadastraSaldoButton = new Button();
            CadastraSaldoButton.BackColor = System.Drawing.Color.Gray;
            CadastraSaldoButton.Text = "Alterar";
            CadastraSaldoButton.Top = 360;
            CadastraSaldoButton.Left = 220;
            CadastraSaldoButton.Width = 70;
            CadastraSaldoButton.Click += (sender, e) => { 
                Controllers.Saldo.alterarSaldos(new Models.Saldo(id, int.Parse(texto_2.Text), int.Parse(texto_3.Text), int.Parse(texto_4.Text))); 
                Views.Saldo.listarSaldos();
                form.Close(); 
                form.Dispose();
                };

            Button SairSaldoButton = new Button();
            SairSaldoButton.BackColor = System.Drawing.Color.Gray;
            SairSaldoButton.Text = "Sair";
            SairSaldoButton.Top = 360;
            SairSaldoButton.Left = 300;
            SairSaldoButton.Width = 60;
            SairSaldoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(texto_1);
            form.Controls.Add(texto_2);
            form.Controls.Add(texto_3);
            form.Controls.Add(texto_4);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(SairSaldoButton);
            form.Controls.Add(CadastraSaldoButton);
            form.ShowDialog();
                  
        }

         public static void excluirSaldo (){
            
            int quantidade = Models.Saldo.saldos.Count + 1;

            Form form = new Form();
            form.Text = "Saldos";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => { form.Dispose(); };

            Label labelCadastrar = new Label();
            labelCadastrar.Text = "Excluir Saldo";
            labelCadastrar.Top = 10;
            labelCadastrar.Left = 200;
            labelCadastrar.Width = 300;

            Label labelNome_3 = new Label();
            labelNome_3.Text = "Id:";
            labelNome_3.Location = new Point(100, 30);
            labelNome_3.AutoSize = true;
            form.Controls.Add(labelNome_3);

            TextBox texto_3 = new TextBox();
            texto_3.Top = 60;
            texto_3.Left = 100;
            texto_3.Width = 300;

            Button CadastraSaldoButton = new Button();
            CadastraSaldoButton.BackColor = System.Drawing.Color.Gray;
            CadastraSaldoButton.Text = "Excluir";
            CadastraSaldoButton.Top = 360;
            CadastraSaldoButton.Left = 220;
            CadastraSaldoButton.Width = 60;
            CadastraSaldoButton.Click += (sender, e) => { 
                Controllers.Saldo.excluirSaldos (int.Parse(texto_3.Text));
                form.Close(); 
                form.Dispose();
                Views.Saldo.listarSaldos();
                };

            Button SairSaldoButton = new Button();
            SairSaldoButton.BackColor = System.Drawing.Color.Gray;
            SairSaldoButton.Text = "Sair";
            SairSaldoButton.Top = 360;
            SairSaldoButton.Left = 300;
            SairSaldoButton.Width = 60;
            SairSaldoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelNome_3);
            form.Controls.Add(texto_3);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(SairSaldoButton);
            form.Controls.Add(CadastraSaldoButton);
            form.ShowDialog();
      
        }
    }
}