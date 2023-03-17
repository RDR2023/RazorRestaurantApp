using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurantApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace RazorRestaurantApp.Pages
{
    
    public class CartModel : PageModel
    {
        public List<MenuItemModel> cartItems = new List<MenuItemModel>();
        
        [BindProperty] //this helps to map the form inputs to the model
        public CustomerModel customer { get; set; } = new CustomerModel();
        
        public void OnGet(int itemID)
        {
            PopulateCartItems();
        }

        public List<MenuItemModel> PopulateCartItems()
        {
            //Id of items added to cart are in session id: ItemsInCart.
            //Populate cartItems list 

            var menu = DBInitialize.GetMenus();
            var temp = HttpContext.Session.GetString("ItemsInCart")?? "";

            if (temp.Length>0)
            {

                foreach (var m in temp.Split(','))
                {
                    int m2 = int.Parse(m.ToString());
                    var itemToOrder = new MenuItemModel();
                    itemToOrder = menu.FirstOrDefault(x => x.ID == m2);
                    if (itemToOrder != null)
                    {
                        cartItems.Add(itemToOrder);
                    }
                }
            }
            return cartItems;
        }
        public void OnPostPlaceOrder(CustomerModel customer)
        {
            //Populate the order model
            OrdersModel order = new OrdersModel();
            order.OrderId = DBInitialize.GenerateID();
            order.Customer  = customer;
            order.OrderDate = DateTime.Now;
            cartItems = PopulateCartItems();
            order.OrderItems = cartItems;

            // code to save to db 

            //clear the cart
            HttpContext.Session.SetString("ItemsInCart", "");

            Response.Redirect("/OrderConfirmation?OrderId=" + order.OrderId);
        }

        
    }
}
