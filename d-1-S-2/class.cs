using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_1_S_2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;

        }






    }

    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public double Coperto { get; set; } = 3.00;

        public void Addproduct(Product product)
        {
            Products.Add(product);
        }


        public void StampaBill()
        { Console.WriteLine("==========================Conto finale ora PAGAAA===========================");
            double total = 0.0;
        foreach (var product in Products)
            {

                Console.WriteLine($"{product.Name} (€ {product.Price})");
                total += product.Price;



            }

            Console.WriteLine($"Servizio al tavolo (€ {Coperto})");
            total += Coperto;

            Console.WriteLine($"Totale da pagare: € {total}");
            Console.WriteLine("=======================================");
        }



    }






    }

