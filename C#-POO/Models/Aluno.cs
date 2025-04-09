using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            //Ao instanciar,podera desta forma receber dados vazios,ou o nome ,tendo duas opçoes
        }
        //Utilizando :base() para parametrizar através da claase pai ,Nome como obrigatório
        public Aluno(string nome) : base(nome)
        {
           
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}