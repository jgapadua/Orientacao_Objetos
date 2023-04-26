using System;

namespace _01Conceitos // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa obj= new Pessoa();
            obj.nome="João";
            obj.idade=22;
            obj.mensagem();
        }
    }
}