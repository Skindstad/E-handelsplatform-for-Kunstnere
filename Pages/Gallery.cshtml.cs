using EhandelsplatformforKunstnere.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EhandelsplatformforKunstnere.Pages
{
    public class GalleryModel : PageModel
    {
        [BindProperty]
        public List<GalleryItem> Items { get; set; } = [
            new () {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJlVjG1qmS1PLitj3275Kk4yFNHeCSY8d2bw&s",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://cdn.britannica.com/87/2087-004-264616BB/Mona-Lisa-oil-wood-panel-Leonardo-da.jpg",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://cdn.shopify.com/s/files/1/0369/6522/0411/files/a16fd418-b113-4a17-890b-ed277c0197f8_600x600.jpg?v=1698914599",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQt4v6zH7HUPxSx4fuZ-mXMRRM2F2rgOdjy_A&s",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://philippefaraut.com/cdn/shop/products/Liana-desat_5456-sfw_1600x.jpg?v=1615149371",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://cdn.prod.website-files.com/6177926b5641c2ccacfc1ad3/649568a7a8a62d807124e772_Jewelry%20as%20an%20Investment.webp",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            },
            new () {
                ImageUrl = "https://media.cnn.com/api/v1/images/stellar/prod/230515143657-0707.jpg?q=w_2000,c_fill",
                Title = "Item 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Artist = "Jannick",
                Price = 9.99m,
                AmountInStock = 2,
                Tags = [
                    new() {Name="Tag 1", Color="red"},
                    new() {Name="Tag 2", Color="blue"},
                    new() {Name="Tag 3", Color="green"}
                ]
            }
        ];
        public void OnGet()
        {
        }
    }
}
