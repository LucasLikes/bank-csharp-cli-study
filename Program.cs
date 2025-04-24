public class Program
{
    public class Conta
    {
        public string Name { get; set; }
        public double Saldo { get; set; }
    }

    static List<Conta> contas = new List<Conta>();

    static void Main()
    {
        int resp;
        string name;

        Console.WriteLine("\n ---- BANCO LIKE'S -----");
        Console.WriteLine();
        Console.WriteLine("Qual seu nome?");
        name = Console.ReadLine();
        Conta conta = BuscarOuCriarConta(name);

        do
        {
            Console.WriteLine("\n1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            resp = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (resp)
            {
                case 1:
                    Depositar(conta);
                    break;
                case 2:
                    Sacar(conta);
                    break;
                case 3:
                    MostrarSaldo(conta);
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar o Banco Like's!");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (resp != 4);
    }

    public static Conta BuscarOuCriarConta(string Name)
    {
        Conta conta = contas.Find(c => c.Name == Name);
        if (conta == null)
        {
            conta = new Conta { Name = Name, Saldo = 0 };
            contas.Add(conta);
        }
        return conta;
    }

    public static void Depositar(Conta Conta)
    {
        Console.WriteLine("Qual o valor a ser depositado? ");
        double valor = double.Parse(Console.ReadLine());
        if (valor <= 0)
        {
            Console.WriteLine("Valor incorreto, por gentileza insira um deposito positivo.");
            return;
        }
        Conta.Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
    }

    public static void Sacar(Conta conta)
    {
        Console.WriteLine("Qual valor gostaria de sacar? ");
        double valor = double.Parse(Console.ReadLine());

        if (valor > conta.Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }

        conta.Saldo -= valor;
        Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
    }

    public static void MostrarSaldo(Conta conta)
    {
        char ultimaLetra = conta.Name.ToLower()[^1];

        if (ultimaLetra == 'a')
        {
            Console.WriteLine($"Olá Senhora {conta.Name}. ");
        }
        else
        {
            Console.WriteLine($"Olá Senhor {conta.Name}. ");
        }
        Console.WriteLine($"\nSeu saldo atual é de: R${conta.Saldo:F2}");
    }
}
