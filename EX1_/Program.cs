﻿namespace animais;
class Program
{
  static void Main(string[] args)
    {
        Homem n1 = new Homem();
        cao n2 = new cao();
        gato n3 = new gato();

        n1.Nome = "Homem";
        n2.Nome = "Cão";
        n3.Nome = "Gato";

        Console.WriteLine("Nome: " + n1.Nome + " : " + n1.fala());
        Console.WriteLine("Nome: " + n2.Nome + " : " + n2.fala());
        Console.WriteLine("Nome: " + n3.Nome + " : " + n3.fala());

    }
}