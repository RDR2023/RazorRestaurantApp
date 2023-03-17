namespace RazorRestaurantApp.Models
{
    public class OrdersModel
    {
        public string? OrderId { get; set; }
        public DateTime OrderDate
        {
            get; set;
        }
        public CustomerModel Customer { get; set; } = new CustomerModel();
        public float TotalPrice { get; set; } = 0;
        public List<MenuItemModel> OrderItems { get; set; }= new List<MenuItemModel>();
    }

}

