using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDeProduto.Entities
{
    class Product
    {
        //Atributos
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
