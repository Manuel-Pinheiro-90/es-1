namespace d_1_S_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;



            List<Product> menu= new List<Product>
            {
                  new Product(1, "Coca Cola 150 ml", 2.50),
                new Product(2, "Insalata di pollo", 5.20),
                new Product(3, "Pizza Margherita", 10.00),
                new Product(4, "Pizza 4 Formaggi", 12.50),
                new Product(5, "Pz patatine fritte", 3.50),
                new Product(6, "Insalata di riso", 8.00),
                new Product(7, "Frutta di stagione", 5.00),
                new Product(8, "Pizza fritta", 5.00),
                new Product(9, "Piadina vegetariana", 6.00),
                new Product(10, "Panino Hamburger", 7.90)
            };


            Order o = new Order();

            while (true)
            {
                Console.WriteLine("==============MENU==============");
                foreach (var product in menu) 
                {
                    Console.WriteLine($"{product.Id}:  {product.Name} (€ {product.Price})");
                }

                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU==============");


                Console.Write("Seleziona un'opzione: ");
                if(int.TryParse(Console.ReadLine(), out int selection))

                    if (selection == 11)
                    {
                        o.StampaBill();
                        break;
                      
                    }
                    else
                    {
                        Product selectedProduct = menu.Find(p => p.Id == selection);
                        if (selectedProduct != null)
                        {
                            o.Addproduct(selectedProduct);
                            Console.WriteLine($"{selectedProduct.Name} aggiunto al conto.");
                        }
                        else
                        {
                            Console.WriteLine("Opzione non valida. Riprova.");
                        }
                    }
           
                else
            {
                Console.WriteLine("Inserisci un numero valido.");
            }

        }
























        }
    }
}
