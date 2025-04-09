using C__POO.Models;
using C__POO.Interfaces;

#region Abstrcao na prática -> Abstrair conceitos do mundo real, considerando seus atributos mais relevantes ao contexto
//Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Idade = 23;
// p1.Apresentar();
#endregion

#region Encapsulamento na prática -> Proteçao contra alteraçoes externas
// ContaCorrente c1 = new ContaCorrente(123,1000);
//c1.saldo = 5000; -> Tentativa de alteraçao
// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();
#endregion

#region Herança na prática -> Reutilizaçao de atributos,métodos e comportamentos de uma classe em outras classes (Aluno e professor herdando atributos da classe Pessoa)
// Aluno a1 = new Aluno();
// a1.Nome = "Josue";
// a1.Nota = 8.00;
// a1.Idade = 18;
// a1.Apresentar();
//Professor prof1 = new Professor();
// prof1.Nome = "Miguel";
// prof1.Idade = 40;
// prof1.Salario = 4000;
// prof1.Apresentar();
#endregion

#region Polimorfismo na prática -> Sobrescrevemos (com virtual na classe pai + override na classe filha) métodos das classes filhas para que se comportem de maneira diferente e que possuam sua propria implementacao
//Adicionando "Virtual" ao método Apresentar() na classe pai;
//             public virtual void Apresentar()
//         {
//             Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
//         }

//Adicionando o método nas classes filhas + "Override"
        //     public override void Apresentar()
//         {
//              System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
//         }
#endregion

#region Classes abstratas (abstract) -> Pode apenas ser herdada, e nao instanciada 
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();
#endregion

#region Constructor por herança
//Ao instanciar, é possivel trazer nenhum dado,ou o nome
// Pessoa p2 = new Pessoa("Lucas");
// Aluno a2 = new Aluno("Gabriel");
#endregion

#region Classe/método selado -> Nao podem ter classes herdadas,nao podem ter métodos sobreescritos por suas classes filhas
#endregion 

#region Interface -> Pode definir métodos abstratos para serem implementados (como uma classe abstrata),nao podendo ser instanciada
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));
#endregion