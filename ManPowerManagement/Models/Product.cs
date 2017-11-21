using ManPowerManagement.Infrastructure;

namespace ManPowerManagement.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Category
    {
        //private readonly ObservableListSource<Product> _products = new ObservableListSource<Product>();

        public int CategoryId { get; set; }
        public string Name { get; set; }
        //public virtual ObservableListSource<Product> Products { get { return _products; } }
    }
}
