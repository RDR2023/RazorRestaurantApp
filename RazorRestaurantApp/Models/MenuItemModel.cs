namespace RazorRestaurantApp.Models
{
    public class MenuItemModel
    {
        public int ID { get; set; }
        public string? ItemName { get; set; }
        public string? ItemImagePath { get; set; }
        public float ItemBasePrice { get; set; } = 2;
        public string? ItemDescription { get; set;}
        public bool TomatoSauce { get; set; } = false;
        public bool Cheese { get; set; } = false;
        public bool Peperoni { get; set; } = false;
        public bool Mushroom { get; set; } = false;
        public bool Tuna { get; set; } = false;

        public float ItemFinalPrice { get; set; }

        
    }
}
