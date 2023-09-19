using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlC_
{
    public class Mutation
    {
        private Data dataBase { get; set; }

        public Mutation(Data data)
        {
            dataBase = data;
        }

        public Product newproduct(string name, decimal price)
        {
            Product product = new Product
            {
                id = dataBase.Products.Count + 1,
                name = name,
                price = price
            };
            dataBase.Products.Add(product);
            return product;
        }

        public Custumer updateCustomerEmail(int custumerId, string email)
        {
            dataBase.Custumers[custumerId - 1].email = email;
            return dataBase.Custumers[custumerId - 1];
        }
    }
}