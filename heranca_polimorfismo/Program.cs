﻿namespace heranca_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Alves";
        n1.Idade = 16;
        n2.Nome = "Harley";
        n2.Idade = 16;
        n3.Nome = "Toninho";
        n3.Idade = 76;
        n3.Cargo = "Aposentado";
        
        Console.WriteLine("Nome: " + n1.Nome + " -- Idade: " + n1.Idade + " -- Part: " +  (n1.Participacao()));
        Console.WriteLine("Nome: " + n2.Nome + " -- Idade: " + n2.Idade + " -- Part: " +  (n2.Participacao()));
        Console.WriteLine("Nome: " + n3.Nome + " -- Idade: " + n3.Idade + " -- Part: " +  (n3.Participacao()) + " -- Cargo: " + n3.Cargo);
    }
}