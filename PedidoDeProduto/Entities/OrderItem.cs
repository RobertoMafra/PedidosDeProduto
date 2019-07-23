using System.Globalization;

namespace PedidoDeProduto.Entities
{
    class OrderItem
    {
        //Atributos
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
               
        //Construtores
        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }



        //Metodos
        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name +
                ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture) +
                ", Quantidade: " + Quantity + ", Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
