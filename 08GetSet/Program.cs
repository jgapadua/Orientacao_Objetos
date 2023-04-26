using System;

namespace _08GetSet // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome="João";
            Console.WriteLine(p.Nome);
        }
    }
}