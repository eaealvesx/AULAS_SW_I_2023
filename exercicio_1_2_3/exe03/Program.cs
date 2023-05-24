﻿namespace exe03;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

        n1.Email = "gabrielsantos170284@gmail.com";
        n1.Nome = "Gabriel Alves";
        n1.Telefone = "(11) 950968704";
        n1.cpf = "422.604.808-37";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "rafael.uberccb@gmail.com";
        n2.Nome = "Rafael";
        n2.Telefone = "(11) 999020629";
        n2.cnpj = "12.33545/0001-00";
        n2.ie = "123.345.678.90";
        n2.NomeEmpresa = "GuaranÁlves";
        n2.Prazo = 10;
        

        Console.WriteLine("os dados da Pessoa Física sao: " + n1.MostraDados());
        Console.WriteLine("os dados da Pessoa Jurídica sao: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}