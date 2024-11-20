namespace Inventory.DB; 

 public record Product 
 {
   public int Id {get; set;} 
   public string ? Name { get; set; }
 }

 public class ProductDB
 {
   private static List<Product> _products = new List<Product>()
   {
     new Product{ Id=1, Name="Montemagno, Pizza shaped like a great mountain" },
     new Product{ Id=2, Name="The Galloway, Pizza shaped like a submarine, silent but deadly"},
     new Product{ Id=3, Name="The Noring, Pizza shaped like a Viking helmet, where's the mead"} 
   };

   public static List<Product> GetProducts() 
   {
     return _products;
   } 

   public static Product ? GetProduct(int id) 
   {
     return _products.SingleOrDefault(product => product.Id == id);
   } 

   public static Product CreateProduct(Product product) 
   {
     _products.Add(product);
     return product;
   }

   public static Product UpdateProduct(Product update) 
   {
     _products = _products.Select(product =>
     {
       if (product.Id == update.Id)
       {
         product.Name = update.Name;
       }
       return product;
     }).ToList();
     return update;
   }

   public static void RemoveProduct(int id)
   {
     _products = _products.FindAll(product => product.Id != id).ToList();
   }
 }