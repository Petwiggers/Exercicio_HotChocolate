namespace GraphQlC_
{
    public class Data
    {
        public List<Product> Products { get; set; }
        public List<Custumer> Custumers { get; set; }
        public List<Order> Orders { get; set; }
        public Data()
        {
            Products = new List<Product>{
                new Product
                {
                    id = 1,
                    name = "Arroz",
                    price = 15.50M,
                },
                new Product
                {
                    id = 2,
                    name = "Feijão",
                    price = 10.99M
                },
                new Product
                {
                    id = 3,
                    name = "Batata",
                    price = 8.49M
                },
                new Product
                {
                    id = 4,
                    name = "Macarrão",
                    price = 7.89M
                }
            };

            Custumers = new List<Custumer>
            {
                new Custumer
                {
                    id = 1,
                    name = "Marcelo",
                    email = "marcelo@teste.com"
                },
                new Custumer
                {
                    id = 2,
                    name = "Peterson",
                    email = "petersonwiggersoficial@gmail.com"
                },
                new Custumer
                {
                    id = 3,
                    name = "Isadora",
                    email = "isadora@teste.com"
                },
                new Custumer
                {
                    id = 4,
                    name = "Rodrigo",
                    email = "rodrigo@teste.com"
                }
            };

            Orders = new List<Order>
            {
                new Order
                {
                    id = 1,
                    custumerId = 2,
                    date = new DateTime(2004,6,21),
                },
                new Order
                {
                    id = 2,
                    custumerId = 1,
                    date = new DateTime(2010,9,26),
                },
                new Order
                {
                    id = 3,
                    custumerId = 4,
                    date =  new DateTime(2023,12,30)
                },
                new Order
                {
                    id = 4,
                    custumerId = 2,
                    date = new DateTime(1999,7,14)
                }
            };
        }
    }
}