using System;
public class Program
{

    //static Dictionary<string, double> estoque = new Dictionary<string, double>();

    static void Main()
    {
        int resp;

        Console.WriteLine("\n ---- STORE LIKE'S -----");
        Console.WriteLine();

        do
        {
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Atualizar preço de um produto");
            Console.WriteLine("3 - Remover produto");
            Console.WriteLine("4 - Mostrar todos os produtos");
            Console.WriteLine("5 - Buscar um produto");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha: ");
            resp = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (resp)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    UpdatePrice();
                    break;
                case 3:
                    DeletProduct();
                    break;
                case 4:
                    GetProducts();
                    break;
                case 5:
                    SearchProduct();
                    break;
                case 6:
                    Console.WriteLine("Até logo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (resp != 6);
    }

    public static void AddProduct()
    {

    }

    public static void UpdatePrice() { }
    public static void DeletProduct() { }
    public static void SearchProduct() { }
    public static void GetProducts() { }
}
