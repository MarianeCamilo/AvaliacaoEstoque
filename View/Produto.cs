using Controllers;

namespace Views
{
    public class Produto
    {
        public static void listarProdutos() {
            Form form = new Form();
            form.Text = "Produtos";
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
            lista.Columns.Add("Nome");
            lista.Columns.Add("Preço");

           foreach(Models.Produto produto in Models.Produto.produtos) {
                lista.Items.Add(new ListViewItem(new string[] {produto.id.ToString(), produto.nome.ToString(), produto.preco.ToString() }));
            }
            
            Button cadastrarProdutoButton = new Button();
            cadastrarProdutoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarProdutoButton.Text = "Adicionar";
            cadastrarProdutoButton.Top = 360;
            cadastrarProdutoButton.Left = 10;
            cadastrarProdutoButton.Width = 70;
            cadastrarProdutoButton.Click += (sender, e) => { Views.Produto.addProduto();

                form.Close(); 
                form.Dispose();
            };

            Button alterarProdutoButton = new Button();
            alterarProdutoButton.BackColor = System.Drawing.Color.Gray;
            alterarProdutoButton.Text = "Alterar";
            alterarProdutoButton.Top = 360;
            alterarProdutoButton.Left = 90;
            alterarProdutoButton.Width = 60;
            alterarProdutoButton.Click += (sender, e) => {Views.Produto.alterarProduto();
            
                form.Close(); 
                form.Dispose();
            };

            Button excluirButton = new Button();
            excluirButton.BackColor = System.Drawing.Color.Gray;
            excluirButton.Text = "Excluir";
            excluirButton.Top = 360;
            excluirButton.Left = 160;
            excluirButton.Width = 60;
            excluirButton.Click += (sender, e) => { Views.Produto.excluirProduto();
            
                form.Close(); 
                form.Dispose();
            };

            Button SairProdutoButton = new Button();
            SairProdutoButton.BackColor = System.Drawing.Color.Gray;
            SairProdutoButton.Text = "Sair";
            SairProdutoButton.Top = 360;
            SairProdutoButton.Left = 230;
            SairProdutoButton.Width = 60;
            SairProdutoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(cadastrarProdutoButton);
            form.Controls.Add(alterarProdutoButton);
            form.Controls.Add(excluirButton);
            form.Controls.Add(SairProdutoButton);
            form.Controls.Add(lista);
            form.Controls.Add(lista);
            form.ShowDialog();

        }

        public static void addProduto (){
            
            int quantidade = Models.Produto.produtos.Count + 1;

            Form form = new Form();
            form.Text = "Produtos";
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
            labelCadastrar.Text = "Cadastrar produto";
            labelCadastrar.Top = 10;
            labelCadastrar.Left = 200;
            labelCadastrar.Width = 300;

            Label labelNome = new Label();
            labelNome.Text = "Nome:";
            labelNome.Location = new Point(100, 30);
            labelNome.AutoSize = true;
            form.Controls.Add(labelNome);

            TextBox texto = new TextBox();
            texto.Top = 55;
            texto.Left = 100;
            texto.Width = 300;
            
            Label labelPreco = new Label();
            labelPreco.Text = "Preço:";
            labelPreco.Location = new Point(100, 90);
            labelPreco.AutoSize = true;
            form.Controls.Add(labelPreco);

            TextBox texto_2 = new TextBox();
            texto_2.Top = 120;
            texto_2.Left = 100;
            texto_2.Width = 300;

            Button CadastraProdutoButton = new Button();
            CadastraProdutoButton.BackColor = System.Drawing.Color.Gray;
            CadastraProdutoButton.Text = "Cadastrar";
            CadastraProdutoButton.Top = 360;
            CadastraProdutoButton.Left = 220;
            CadastraProdutoButton.Width = 70;
            CadastraProdutoButton.Click += (sender, e) => { 
                Controllers.Produto.criarProduto(new Models.Produto(quantidade, texto.Text,int.Parse(texto_2.Text))); 
                form.Close(); 
                form.Dispose();
                Views.Produto.listarProdutos();
                };

            Button SairProdutoButton = new Button();
            SairProdutoButton.BackColor = System.Drawing.Color.Gray;
            SairProdutoButton.Text = "Sair";
            SairProdutoButton.Top = 360;
            SairProdutoButton.Left = 300;
            SairProdutoButton.Width = 60;
            SairProdutoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(texto_2);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(texto);
            form.Controls.Add(SairProdutoButton);
            form.Controls.Add(CadastraProdutoButton);
            form.ShowDialog();
      
        }

        public static void alterarProduto (){
            
            int quantidade = Models.Produto.produtos.Count + 1;

            Form form = new Form();
            form.Text = "Produtos";
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
            labelCadastrar.Text = "Alterar Produto";
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

            Label labelNome = new Label();
            labelNome.Text = "Nome:";
            labelNome.Location = new Point(100, 90);
            labelNome.AutoSize = true;
            form.Controls.Add(labelNome);

            TextBox texto = new TextBox();
            texto.Top = 120;
            texto.Left = 100;
            texto.Width = 300;
            
            Label labelPreco = new Label();
            labelPreco.Text = "Preço:";
            labelPreco.Location = new Point(100, 160);
            labelPreco.AutoSize = true;
            form.Controls.Add(labelPreco);

            TextBox texto_2 = new TextBox();
            texto_2.Top = 190;
            texto_2.Left = 100;
            texto_2.Width = 300;

            Button CadastraProdutoButton = new Button();
            CadastraProdutoButton.BackColor = System.Drawing.Color.Gray;
            CadastraProdutoButton.Text = "Alterar";
            CadastraProdutoButton.Top = 360;
            CadastraProdutoButton.Left = 220;
            CadastraProdutoButton.Width = 70;
            CadastraProdutoButton.Click += (sender, e) => { 
                Controllers.Produto.alterarProdutos(new Models.Produto(int.Parse(texto_3.Text), texto.Text,int.Parse(texto_2.Text))); 
                form.Close(); 
                form.Dispose();
                Views.Produto.listarProdutos();
                };

            Button SairProdutoButton = new Button();
            SairProdutoButton.BackColor = System.Drawing.Color.Gray;
            SairProdutoButton.Text = "Sair";
            SairProdutoButton.Top = 360;
            SairProdutoButton.Left = 300;
            SairProdutoButton.Width = 60;
            SairProdutoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelNome_3);
            form.Controls.Add(texto_3);
            form.Controls.Add(texto_2);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(texto);
            form.Controls.Add(SairProdutoButton);
            form.Controls.Add(CadastraProdutoButton);
            form.ShowDialog();
      
        }

         public static void excluirProduto (){
            
            int quantidade = Models.Produto.produtos.Count + 1;

            Form form = new Form();
            form.Text = "Produtos";
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
            labelCadastrar.Text = "Excluir Produto";
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

            Button CadastraProdutoButton = new Button();
            CadastraProdutoButton.BackColor = System.Drawing.Color.Gray;
            CadastraProdutoButton.Text = "Excluir";
            CadastraProdutoButton.Top = 360;
            CadastraProdutoButton.Left = 220;
            CadastraProdutoButton.Width = 60;
            CadastraProdutoButton.Click += (sender, e) => { 
                Controllers.Produto.excluirProdutos (int.Parse(texto_3.Text));
                form.Close(); 
                form.Dispose();
                Views.Produto.listarProdutos();
                };

            Button SairProdutoButton = new Button();
            SairProdutoButton.BackColor = System.Drawing.Color.Gray;
            SairProdutoButton.Text = "Sair";
            SairProdutoButton.Top = 360;
            SairProdutoButton.Left = 300;
            SairProdutoButton.Width = 60;
            SairProdutoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelNome_3);
            form.Controls.Add(texto_3);
            form.Controls.Add(labelCadastrar);
            form.Controls.Add(SairProdutoButton);
            form.Controls.Add(CadastraProdutoButton);
            form.ShowDialog();
      
        }
    }
}