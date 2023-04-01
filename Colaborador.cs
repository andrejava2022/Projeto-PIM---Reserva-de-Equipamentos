    namespace SistemaDeReservaDeEquipamentos
{
    public class Colaborador : Reserva
    {
        TelaEquipamentos tela { get; set; }
        public string Cpf = "";
        public string Nome = "";
      
        public Colaborador() { }

        public Colaborador(string Nome, string Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
        }

        public bool verificarCadastro(string Nome, string Cpf )
        {
            string[] nomes = Nome.Split(' ');
            string primeiroNome = nomes[0];
            string nomeMinusc = Nome.ToLower();

            if (nomeMinusc.Length >= 10)
            {
                if (Cpf.Length == 14)
                {
                    if (nomeMinusc == "lorenzo castro" && Cpf == "714.426.638-12" ||
                        nomeMinusc == "isaac ferreira" && Cpf == "047.957.197-05" ||
                        nomeMinusc == "stella barbosa" && Cpf == "334.014.371-43" ||
                        nomeMinusc == "catarina silva" && Cpf == "324.885.472-39"||
                        nomeMinusc == "yago barros"  && Cpf == "067.283.832-04" ||
                        nomeMinusc == "isabelly da rocha" && Cpf == "877.769.851-71" ||
                        nomeMinusc == "raul peixoto" && Cpf == "143.062.360-80" ||
                        nomeMinusc == "isabel da cruz" && Cpf == "741.880.072-06"||
                        nomeMinusc == "clara da luz" && Cpf == "855.217.766-80" || 
                        nomeMinusc == "amanda viana" && Cpf == "235.500.822-15" ||
                        nomeMinusc == "samuel dias" && Cpf == "515.513.873-60" ||
                        nomeMinusc == "letícia santos" && Cpf == "489.171.926-53" ||
                        nomeMinusc == "igor da paz" && Cpf == "722.881.438-00" ||
                        nomeMinusc == "ana julia teixeira" && Cpf == "085.048.281-07" ||
                        nomeMinusc == "alexia costa" && Cpf == "376.303.631-84" ||
                        nomeMinusc == "luigi ribeiro" && Cpf == "936.645.610-31" ||
                        nomeMinusc == "olivia nogueira" && Cpf == "567.377.673-03" ||
                        nomeMinusc == "melissa nogueira" && Cpf == "118.915.285-13" ||
                        nomeMinusc == "catarina pires" && Cpf == "819.434.261-98" ||
                        nomeMinusc == "enzo gabriel da rosa" && Cpf == "243.110.809-05")
                    {
                        Colaborador colaborador = new Colaborador(Nome, Cpf);
                        MessageBox.Show("Usuario registrado\nNome: " + Nome +"\n"+ "CPF: "+Cpf+"\n"+"Seja Bem Vindo " + nomes[0] +", Faça sua Reserva!");
                        return true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Dados Inválidos!", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Verifique seu CPF", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Preencha seu Nome Completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




        }

        public override string ToString()
        {
            return  Nome + "\nCPF: " + Cpf;
        }


    }
}
