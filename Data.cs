using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlC_
{
    public class Data
    {
        public List<Product> Products { get; set; }
        public List<Custumer> Custumers { get; set; }
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
        }
    }
}