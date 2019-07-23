using PedidoDeProduto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDeProduto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        //Construtores
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Metodos
        public void AddItens(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItens(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach(OrderItem item in Itens)
            {
                total = total + item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        


    }
}
