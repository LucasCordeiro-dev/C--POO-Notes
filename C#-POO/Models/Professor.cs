using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    //Atraves da "Sealed",bloqueia classes filhas
    public  class Professor : Pessoa
    {
        public Professor()
        {
            //Ao instanciar,podera desta forma receber dados vazios,ou o nome ,tendo duas opçoes
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public Decimal Salario { get; set; }

        //Através da "Sealed",nao permite o método ser sobreescrito
        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Olá, me chamo {Nome},tenho {Idade} anos,sou professor e ganho R${Salario}");
        }
    }
}