using System;

namespace _04ExercicioIMC // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.altura=1.71;
            p.peso=75;
            p.mensagem();
        }
    }
}