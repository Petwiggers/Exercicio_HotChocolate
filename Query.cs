
using System.Globalization;

namespace GraphQlC_
{
  public class Query
  {
    private Data dataBase { get; set; }

    public Query(Data data)
    {
      dataBase = data;
    }
    public List<Product> products()
    {
      return dataBase.Products;
    }
    public Custumer custumers(int id)
    {
      return dataBase.Custumers.FirstOrDefault(x => x.id == id);
    }
  }
}