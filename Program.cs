namespace Aeroporto_Projeto;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Bem vindo ao nosso Aeroporto!");
        Console.WriteLine("Favor, digite o número com o que corresponde a você:");
        Console.WriteLine("1 - Sou funcionário.");
        Console.WriteLine("2 - Sou passageiro.");

        int opcao = Console.Read();
        
        if(opcao == 1){
            Console.WriteLine("Você é funcionário.");
        }

        if(opcao == 2) {
            Console.WriteLine("Precisamos de alguns dados seus.");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá passageiro, oque deseja fazer?");
            Console.WriteLine("1 - Comprar passagem.");
            Console.WriteLine("2 - Fazer checkIn");
            opcao = Console.Read();
            if(opcao == 1){
                
            }
            if(opcao == 2){
                Console.WriteLine("Favor falar ID da sua passagem.");
            }
        }

    }
}
