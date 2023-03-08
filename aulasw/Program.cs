namespace aulasw;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
       // Console.ReadKey();

       //instenciar um objeto a partir de uma classe
       exemplo exe01 = new exemplo();

       exe01.mostramsg();

       exe01.mostranome("Alvoroço");

       Console.WriteLine(exe01.msg());
       
        Console.WriteLine("A soma é: " + exe01.somar(10,20));

    }
}

