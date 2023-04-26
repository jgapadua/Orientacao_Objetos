using System;

namespace _03ExercicioEscolar // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            //Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome="Daniel";
            a.nota1=5;
            a.nota2=3;
            a.mensagem();
        }
    }
}
