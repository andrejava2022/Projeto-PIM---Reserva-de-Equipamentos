using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReservaDeEquipamentos
{
    public class Reserva : Form
    {
        TelaEquipamentos tela { get; set; }
        int Id { get; set; }
        DateTime dataRegistro;
        string dataInicial { get; set; }
        string dataFinal { get; set; }

        string horaFinal { get; set; }
        string horaInicial { get; set; }

        int id { get; set; }

        Colaborador colaborador ;
       

        public Reserva()
        {
            
        }

        public Reserva(int id, DateTime dataRegistro, string dataInicial,string horaInicial, string dataFinal,
            string horaFinal,Colaborador colaborador)
        {
            //this.id = id;
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.dataRegistro = dataRegistro;
            this.dataInicial = dataInicial;
            this.horaFinal = horaFinal;
            this.horaInicial = horaInicial;
            this.dataFinal = dataFinal;
            this.colaborador = colaborador;
            
        }

        public void cancelarReserva()
        {
            try 
            {
                if (tela.maskedTextBoxCpf.Text != null && tela.maskedTextBoxCpfCancela.Text != null)
                {
                    if (tela.maskedTextBoxCpf.Text == tela.maskedTextBoxCpfCancela.Text)
                    {
                        MessageBox.Show("Reserva excluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Reserva não encontrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Reserva não encontrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(NullReferenceException e) 
            { 
               MessageBox.Show("Ocorreu um erro! Verifique se você preencheu todos os campos",e.Message,MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Número da solicitação: " + Id + "\n");
            sb.Append("Data de registro: "+ dataRegistro + "\n");
            sb.Append("Inicio: "+dataInicial+ " " +horaInicial+ "\n");
            sb.Append("Término: " +dataFinal+ " " +horaFinal+ "\n");
            sb.Append("Solicitante: " +colaborador+ "\n");
            sb.Append("Solicitação de Reserva Registrada com Sucesso!");
            return sb.ToString();

        }
    }
}
