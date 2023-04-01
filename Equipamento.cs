using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaDeReservaDeEquipamentos
{
    public class Equipamento : Form
    {
        string Nome;
        string Descricao;
        int Quantidade = 1;

        Equipamento equipamento;

        public List<Equipamento> listaDeEquipamentos = new List<Equipamento>();
       // TelaEquipamentos tela = new TelaEquipamentos();

        public Equipamento() { }

        public Equipamento(string nome, string descricao, int quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
        }

         public override string ToString()
        {

            return "Lista de Equipamentos: \n" + listaDeEquipamentos.Count;
        }

    }
}
