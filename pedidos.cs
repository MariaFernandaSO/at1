
using System.Collections.Generic;
using System;
namespace atividade_1
{
    public class pedidos
    {
       private List<itemPedido> itemPedido;
      
      public pedidos(){
          itemPedido = new List<itemPedido>();
      }
      public void AddPedidos(string produto, float preco, int quantidade){
          itemPedido.Add(new itemPedido(produto, preco, quantidade));

      }
      public double TotalPedidos(){
          double total = 0;
          foreach(var item in itemPedido){
              Console.WriteLine("Produto: {0} valor: {1} quantidade: {2}", item.produto, item.preco, item.quantidade);
              total = total + (item.preco * item.quantidade);
          }
          return total; 
      }
    }
}