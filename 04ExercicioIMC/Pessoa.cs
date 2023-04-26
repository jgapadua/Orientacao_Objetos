using System;

class Pessoa
{
    //Atributos
    public double peso, altura;

    //Métodos
    //Calcular IMC
    public double calculo()
    {
        return peso/(altura*altura);
    }
    //Situação
    public string situacao(double imc)
    {
        //Variável
        string strIMC;
        //Condicional
        if(imc<18.5)
        {
            strIMC="Abaixo do peso";
        }else if(imc<25)
        {
            strIMC="Peso normal";
        }
        else if(imc<30)
        {
            strIMC="Acima do peso";
        }
        else if(imc<35)
        {
            strIMC="Obesidade I";
        }
        else if(imc<40)
        {
            strIMC="Obesidade II";
        }
        else{
            strIMC="Obesidade III";
        }
        //Retorno
        return strIMC;
    }
    //Mensagem
    public void mensagem()
    {
        //Obter o cálculo
        double obterCalculo= Math.Round(calculo(),1);

        //Obter a situação
        string obterSituacao=situacao(obterCalculo);

        //Exibir mensagem
        Console.WriteLine("Seu IMC: "+obterCalculo+" - "+obterSituacao);
    }
}