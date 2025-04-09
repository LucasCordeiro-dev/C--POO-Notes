using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Interfaces
{
    //Padronizar o I antes do nome da classe,mostrando ser Interface
    public interface ICalculadora
    {
        //Métodos sem corpo = Obrigatorios para a implementaçao
        int Soamr(int num1,int num2);
         int Subtrair(int num1,int num2);
          int Multiplicar(int num1,int num2);

        //Métodos com corpo = Opcionais
        //É possível ter método padrao na interface,nao precisando colocar na classe filha
          public int Dividir(int num1,int num2)
          {
            return num1 / num2;
          }
    }
}