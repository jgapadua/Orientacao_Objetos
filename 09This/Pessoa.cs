using System;

class Pessoa
{
    //Atributos
    private string nome="Tati";

    //Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}