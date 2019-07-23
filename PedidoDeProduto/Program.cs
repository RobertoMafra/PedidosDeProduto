using PedidoDeProduto.Entities;
using PedidoDeProduto.Entities.Enums;
using System;
using System.Globalization;
namespace PedidoDeProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar com os dados do cliente
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de aniversário (DD/MM/YYYY): ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());

            //Entrar com os dados do pedido
            Console.Write("Entre com o status do pedido: ");
            OrderStatus status= Enum.Parse<OrderStatus>(Console.ReadLine());

            //Criar o cliente
            Client client = new Client(nome, email, dataAniversario);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos intens serão comprados: ");
            int pedidos = int.Parse(Console.ReadLine());

            for (int posicao = 0; posicao < pedidos; posicao = posicao + 1)
            {
                //Receber os dados do produto
                Console.WriteLine($"Entre com os dados do #{posicao + 1} item: ");
                Console.Write("Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidades: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                //Instaciar o produto e o pedido
                Product product = new Product(nomeProduto, precoProduto);
                OrderItem orderItem = new OrderItem(quantidadeProduto, precoProduto, product);

                //Adicionar os valores na lista
                order.AddItens(orderItem);
            }

            //Mostrar os pedidos
            Console.WriteLine();
            Console.WriteLine("Resumo do pedido: ");
            Console.WriteLine("Horário do pedido: " + order.Moment);
            Console.WriteLine("Status do pedido: " + status);
            Console.WriteLine("Cliente: " + client);
            Console.WriteLine("Itens pedidos: ");
            Console.WriteLine(order);
            Console.WriteLine("Preço Total: " + order.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
