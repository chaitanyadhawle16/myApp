namespace myApp.Models;

public class ProductDetails{
    public int Id { get; set;} 
     public string Title { get; set;}
     public string Description { get; set;}
     public int Price { get; set;}
     public int DiscountPercentage { get; set;}
     public int Rating { get; set;}
     public int Stock { get; set;}
     public string Brand { get; set;}
     public string Category { get; set;}
     public string Thumbnail { get; set;}
     public List<String> Images {get; set;}
}