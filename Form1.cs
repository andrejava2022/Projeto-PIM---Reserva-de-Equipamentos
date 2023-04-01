namespace SistemaDeReservaDeEquipamentos
{
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();

        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("Digite o nome de usuário!", "Campo usuário vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxUsuario.Text == "teste")
                {
                    if (textBoxSenha.Text == "")
                    {
                        MessageBox.Show("Digite a senha de usuário!", "Campo senha vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (textBoxSenha.Text == "123")
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TelaEquipamentos form2 = (TelaEquipamentos)Application.OpenForms["xyz"];
                            if (form2 == null)
                            {
                                form2 = new TelaEquipamentos();
                                form2.Name = "xyz";
                                form2.Show();
                                labelTextoStatus.Text = "USUÁRIO CONECTADO";
                                buttonLogin.Enabled = false;
                                textBoxUsuario.Enabled = false;
                                textBoxSenha.Enabled = false;
                                textBoxUsuario.Text = "";
                                textBoxSenha.Text = "";


                            }
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário incorreto!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


    }
}