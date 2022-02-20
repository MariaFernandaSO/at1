using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            itemPedido item = new itemPedido();
            pedidos pedido = new pedidos();
            char resposta = 's';

            string produto;
            float preco;
            int quantidade;
            
            //perguntar ao usuario o pedido e depois se ele deseja fazer mais pedidos.
            do
            {
                Console.WriteLine("Digite o nome do produto");
                produto = Console.ReadLine();
                Console .WriteLine("Digite o preço");
                preco = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade");
                quantidade = int.Parse(Console.ReadLine());
                pedido.AddPedidos(produto, preco, quantidade);
                Console.WriteLine("Deseja pedir mais? (s/n)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 's');


            Console.WriteLine("O total do seu pedido e: " + pedido.TotalPedidos());
                    
                
            


       
        }
    }
}
