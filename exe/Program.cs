namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        produto p1 = new produto();

        //p1.nome = "parafuso";
        p1.AlteraNome("parafuso");
        //p1.preco = 1.67;
        p1.AlteraPreco(1.98);
        
        p1.MostraDados();
    }
}
