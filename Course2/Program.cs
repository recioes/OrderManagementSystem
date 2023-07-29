using Course2.Entities;
using Course2.Entities.Enums;
using System;
using System.Diagnostics;

namespace Course2
{ 
class Program
{
    static void Main(string[] args)
    {

        // Dados do cliente
        Console.WriteLine("Enter client's data: ");
        Console.Write("name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Client client = new Client(name, email, birthDate); // criação do objeto (instanciando)
        
        // Dados do pedido
        Console.WriteLine("Enter order's data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        // Criação do objeto do pedido
        Order order = new Order(DateTime.Now, status, client);

        //Dados dos itens
        Console.Write("How many items are there in this order? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)   // Loop para os dados dos itens
        {
            Console.WriteLine($"Enter #{i} item data: ");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Product product = new Product(productName, price); // instanciando o objeto do produto
            OrderItem item = new OrderItem(quantity, price, product); // instanciando o objeto do orderItem
            order.AddItem(item);

        }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);



        }

    }
}
