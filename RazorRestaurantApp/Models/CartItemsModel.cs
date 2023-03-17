namespace RazorRestaurantApp.Models
{
    public class CartItemsModel
    {
        public string? CartId {
            get
            {
                return CartId;
            }
            set
            {
                string id = DBInitialize.GenerateID();
                if (id  == null)
                    throw new ArgumentNullException("CartId cannot be null");
            } 
        }
        public List<MenuItemModel>? OrderItems { get; set; } = new List<MenuItemModel>();
    }
}
