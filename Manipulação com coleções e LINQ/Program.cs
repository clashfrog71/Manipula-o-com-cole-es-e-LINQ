using System.Threading.Channels;

class Program
{

    public static void Main(string[] args)
    {
        string[] diasDaSemana = new string[]
     {
        "Domingo",
        "Segunda-feira",
        "Terça-feira",
        "Quarta-feira",
        "Quinta-feira",
        "Sexta-feira",
        "Sábado"
     };
        Array carrinho = Array.CreateInstance(typeof(Produto), 3);
foreach(var dia in diasDaSemana)
        {
            Console.WriteLine(dia);
        }
    }
}
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}