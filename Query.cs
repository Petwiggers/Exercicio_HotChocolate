
namespace GraphQlC_
{
  public class Query
  {
    public Product getAllProducts()
    {
      return new Product
      {
        id = 1,
        name = "Pacote de Arroz",
        price = 12.50M
      };
    }
  }
}