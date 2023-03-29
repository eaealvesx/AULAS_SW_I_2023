namespace exemplo;
class produto
{
    public string? nome{get;set;}
    public double preco{get;set;}

    public void MostraDados(){
        Console.WriteLine("nome: " + this.nome);
        Console.WriteLine("preço: " + this.preco);
    }
    public void AlteraNome(string nome){
        this.nome = nome;
    }
    public void AlteraPreco(double preco){
        this.preco = preco;
    }
}