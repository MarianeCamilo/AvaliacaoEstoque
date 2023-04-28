using Controllers;

namespace Views
{
    public class Almoxarifado
    {
        public static void listarAlmoxarifados() {
            Form form = new Form();
            form.Text = "Almoxarifados";
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

           foreach(Models.Almoxarifado almoxarifado in Models.Almoxarifado.almoxarifados) {
                lista.Items.Add(new ListViewItem(new string[] {almoxarifado.id.ToString(), almoxarifado.nome.ToString()}));
            }
            
            Button cadastrarAlmoxarifadoButton = new Button();
            cadastrarAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            cadastrarAlmoxarifadoButton.Text = "Adicionar";
            cadastrarAlmoxarifadoButton.Top = 360;
            cadastrarAlmoxarifadoButton.Left = 10;
            cadastrarAlmoxarifadoButton.Width = 70;
            cadastrarAlmoxarifadoButton.Click += (sender, e) => { Views.Almoxarifado.addAlmoxarifado();
            
                form.Close(); 
                form.Dispose();
            };

            Button alterarAlmoxarifadoButton = new Button();
            alterarAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            alterarAlmoxarifadoButton.Text = "Alterar";
            alterarAlmoxarifadoButton.Top = 360;
            alterarAlmoxarifadoButton.Left = 90;
            alterarAlmoxarifadoButton.Width = 60;
            alterarAlmoxarifadoButton.Click += (sender, e) => {Views.Almoxarifado.alterarAlmoxarifado();
            
                form.Close(); 
                form.Dispose();
            };

            Button excluirButton = new Button();
            excluirButton.BackColor = System.Drawing.Color.Gray;
            excluirButton.Text = "Excluir";
            excluirButton.Top = 360;
            excluirButton.Left = 160;
            excluirButton.Width = 60;
            excluirButton.Click += (sender, e) => { Views.Almoxarifado.excluirAlmoxarifado();
            
                form.Close(); 
                form.Dispose();
            };

            Button SairAlmoxarifadoButton = new Button();
            SairAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            SairAlmoxarifadoButton.Text = "Sair";
            SairAlmoxarifadoButton.Top = 360;
            SairAlmoxarifadoButton.Left = 230;
            SairAlmoxarifadoButton.Width = 60;
            SairAlmoxarifadoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(cadastrarAlmoxarifadoButton);
            form.Controls.Add(alterarAlmoxarifadoButton);
            form.Controls.Add(excluirButton);
            form.Controls.Add(SairAlmoxarifadoButton);
            form.Controls.Add(lista);
            form.Controls.Add(lista);
            form.ShowDialog();

        }

        public static void addAlmoxarifado (){
            
            int id = Models.Almoxarifado.almoxarifados.Count + 1;

            Form form = new Form();
            form.Text = "Almoxarifados";
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

            Label labelAlterar = new Label();
            labelAlterar.Text = "Cadastrar almoxarifado";
            labelAlterar.Top = 10;
            labelAlterar.Left = 200;
            labelAlterar.Width = 300;

            Label labelAlterarNome = new Label();
            labelAlterarNome.Text = "Nome:";
            labelAlterarNome.Location = new Point(100, 30);
            labelAlterarNome.AutoSize = true;
            form.Controls.Add(labelAlterarNome);

            TextBox textoNome = new TextBox();
            textoNome.Top = 55;
            textoNome.Left = 100;
            textoNome.Width = 300;
            
            Button CadastraAlmoxarifadoButton = new Button();
            CadastraAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            CadastraAlmoxarifadoButton.Text = "Cadastrar";
            CadastraAlmoxarifadoButton.Top = 360;
            CadastraAlmoxarifadoButton.Left = 220;
            CadastraAlmoxarifadoButton.Width = 70;
            CadastraAlmoxarifadoButton.Click += (sender, e) => { 
                Controllers.Almoxarifado.criarAlmoxarifado(new Models.Almoxarifado(id, textoNome.Text)); 
                form.Close(); 
                form.Dispose();
                Views.Almoxarifado.listarAlmoxarifados();
                };

            Button SairAlmoxarifadoButton = new Button();
            SairAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            SairAlmoxarifadoButton.Text = "Sair";
            SairAlmoxarifadoButton.Top = 360;
            SairAlmoxarifadoButton.Left = 300;
            SairAlmoxarifadoButton.Width = 60;
            SairAlmoxarifadoButton.Click += (sender, e) => { form.Close(); 
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelAlterar);
            form.Controls.Add(textoNome);
            form.Controls.Add(SairAlmoxarifadoButton);
            form.Controls.Add(CadastraAlmoxarifadoButton);
            form.ShowDialog();
      
        }

        public static void alterarAlmoxarifado (){
            
            int quantidade = Models.Almoxarifado.almoxarifados.Count + 1;

            Form form = new Form();
            form.Text = "Almoxarifados";
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

            Label labelAlterar = new Label();
            labelAlterar.Text = "Alterar Almoxarifado";
            labelAlterar.Top = 10;
            labelAlterar.Left = 200;
            labelAlterar.Width = 300;

            Label labelAlterarId = new Label();
            labelAlterarId.Text = "Id:";
            labelAlterarId.Location = new Point(100, 30);
            labelAlterarId.AutoSize = true;
            form.Controls.Add(labelAlterarId);

            TextBox texto_3 = new TextBox();
            texto_3.Top = 60;
            texto_3.Left = 100;
            texto_3.Width = 300;

            Label labelAlterarNome = new Label();
            labelAlterarNome.Text = "Nome:";
            labelAlterarNome.Location = new Point(100, 90);
            labelAlterarNome.AutoSize = true;
            form.Controls.Add(labelAlterarNome);

            TextBox texto = new TextBox();
            texto.Top = 120;
            texto.Left = 100;
            texto.Width = 300;

            TextBox texto_2 = new TextBox();
            texto_2.Top = 190;
            texto_2.Left = 100;
            texto_2.Width = 300;

            Button CadastraAlmoxarifadoButton = new Button();
            CadastraAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            CadastraAlmoxarifadoButton.Text = "Alterar";
            CadastraAlmoxarifadoButton.Top = 360;
            CadastraAlmoxarifadoButton.Left = 220;
            CadastraAlmoxarifadoButton.Width = 70;
            CadastraAlmoxarifadoButton.Click += (sender, e) => { 
                Controllers.Almoxarifado.alterarAlmoxarifados(new Models.Almoxarifado(int.Parse(texto_3.Text), texto.Text)); // ,int.Parse(texto_2.Text)
                form.Close(); 
                form.Dispose();
                Views.Almoxarifado.listarAlmoxarifados();
                };

            Button SairAlmoxarifadoButton = new Button();
            SairAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            SairAlmoxarifadoButton.Text = "Sair";
            SairAlmoxarifadoButton.Top = 360;
            SairAlmoxarifadoButton.Left = 300;
            SairAlmoxarifadoButton.Width = 60;
            SairAlmoxarifadoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelAlterarId);
            form.Controls.Add(texto_3);
            form.Controls.Add(texto_2);
            form.Controls.Add(labelAlterar);
            form.Controls.Add(texto);
            form.Controls.Add(SairAlmoxarifadoButton);
            form.Controls.Add(CadastraAlmoxarifadoButton);
            form.ShowDialog();
      
        }

         public static void excluirAlmoxarifado (){
            
            int quantidade = Models.Almoxarifado.almoxarifados.Count + 1;

            Form form = new Form();
            form.Text = "Almoxarifados";
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

            Label labelAlterar = new Label();
            labelAlterar.Text = "Excluir Almoxarifado";
            labelAlterar.Top = 10;
            labelAlterar.Left = 200;
            labelAlterar.Width = 300;

            Label labelAlterarId = new Label();
            labelAlterarId.Text = "Id:";
            labelAlterarId.Location = new Point(100, 30);
            labelAlterarId.AutoSize = true;
            form.Controls.Add(labelAlterarId);

            TextBox texto_3 = new TextBox();
            texto_3.Top = 60;
            texto_3.Left = 100;
            texto_3.Width = 300;

            Button CadastraAlmoxarifadoButton = new Button();
            CadastraAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            CadastraAlmoxarifadoButton.Text = "Excluir";
            CadastraAlmoxarifadoButton.Top = 360;
            CadastraAlmoxarifadoButton.Left = 220;
            CadastraAlmoxarifadoButton.Width = 60;
            CadastraAlmoxarifadoButton.Click += (sender, e) => { 
                Controllers.Almoxarifado.excluirAlmoxarifados (int.Parse(texto_3.Text));
                form.Close(); 
                form.Dispose();
                Views.Almoxarifado.listarAlmoxarifados();
                };

            Button SairAlmoxarifadoButton = new Button();
            SairAlmoxarifadoButton.BackColor = System.Drawing.Color.Gray;
            SairAlmoxarifadoButton.Text = "Sair";
            SairAlmoxarifadoButton.Top = 360;
            SairAlmoxarifadoButton.Left = 300;
            SairAlmoxarifadoButton.Width = 60;
            SairAlmoxarifadoButton.Click += (sender, e) => { form.Close();
            
                form.Close(); 
                form.Dispose();
            };

            form.Controls.Add(labelAlterarId);
            form.Controls.Add(texto_3);
            form.Controls.Add(labelAlterar);
            form.Controls.Add(SairAlmoxarifadoButton);
            form.Controls.Add(CadastraAlmoxarifadoButton);
            form.ShowDialog();
      
        }
    }
}