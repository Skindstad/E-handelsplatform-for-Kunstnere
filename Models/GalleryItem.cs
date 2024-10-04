namespace EhandelsplatformforKunstnere.Models;




public class GalleryItem
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Artist { get; set; }
    public decimal Price { get; set; }
    public int AmountInStock { get; set; }
    public List<Tag> Tags { get; set; }
}

public class Tag
{
    public string Name { get; set; }
    public string Color { get; set; }
}
