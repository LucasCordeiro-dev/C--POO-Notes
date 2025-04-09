using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    public abstract class Conta
    {
        //Protected é como o private (bloqueia alteraçoes externas) ,porém permite alteraçao nas classes filhas
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}