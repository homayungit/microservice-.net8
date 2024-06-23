using Marten.Schema;

namespace hm.CatalogApi.Data
{
    public class CatalogInitialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            using var session = store.LightweightSession();

            if (await session.Query<Product>().AnyAsync())
                return;

            //Marten UPSERT will cater for existing record
            session.Store<Product>(GetPreconfiguredProducts());
            await session.SaveChangesAsync();
            
        }

        private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>
        {
            new Product()
            {
                Id = new Guid("01904429-bf35-44a5-a3b7-209a592fd85a"),
                Name = "IPhone X",
                Description = "This phone is companies biggest change",
                ImageFile = "product-1.png",
                Price = 120000.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("01907529-bf35-44a5-a3b7-209a592fd85b"),
                Name = "Samsung S23",
                Description = "This phone is companies biggest change",
                ImageFile = "product-1.png",
                Price = 140000.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("01904430-bf35-44a5-a3b7-209a592fd85c"),
                Name = "IPhone 15 pro max",
                Description = "This phone is companies biggest change",
                ImageFile = "product-1.png",
                Price = 120000.00M,
                Category = new List<string> {"Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("01904415-bf35-44a5-a3b7-209a592fd73a"),
                Name = "Samsung S23 Ultra ",
                Description = "This phone is companies biggest change",
                ImageFile = "product-1.png",
                Price = 65555,
                Category = new List<string> {"Smart Phone"}
            }
        };
    }
}
