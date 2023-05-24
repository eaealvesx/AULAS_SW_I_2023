﻿namespace exe02;
class Program
{
    static void Main(string[] args)
    {
        ContatoPessoaFisica n1 = new ContatoPessoaFisica();
        ContatoPessoaJuridica n2 = new ContatoPessoaJuridica();

        n1.Nome = "Gabriel Alves";
        n1.Email = "gabrielsantos170284@gmail.com";
        n1.Telefone = "950968704";
        n1.CPF = "422.604.808-37";
        n1.Idade = 16;

        n2.Nome = "Rafael";
        n2.Email = "rafael.uberccb@gmail.com";
        n2.Telefone = "999020629";
        n2.CNPJ = "13242423";
        n2.IE = "2123123123";
        n2.NomeDaEmpresa = "GuaranÁlves";

        Console.WriteLine(n1.MostrarDados());
        Console.WriteLine();
        Console.WriteLine(n2.MostrarDados());
    }
}