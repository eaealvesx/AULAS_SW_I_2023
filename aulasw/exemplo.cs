namespace aulasw;
class exemplo
{
    //atributos
    public string nome = "";
    public int idade = 0;
    public bool vacinado = false;

   //metodos
   public void mostramsg(){
    Console.WriteLine("Alves lindo!");
   }

   public void mostranome(string texto){
      Console.WriteLine("Nhe " + texto);
   }

   public string msg(){
        return "Maribondo Perigoso!";
   }

        public int somar(int a,int b){
            return a+b;
        }
}