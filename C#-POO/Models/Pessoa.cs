using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            //Ao instanciar,podera desta forma receber dados vazios,ou o nome ,tendo duas opçoes
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }    
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}