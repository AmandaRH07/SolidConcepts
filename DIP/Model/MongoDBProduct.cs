using DIP.Model;

namespace DIP.Factory
{
    class MongoDBProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDb: Exibindo dados do produto {id}.";
        }
    }
}