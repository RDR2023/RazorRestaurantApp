using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurantApp.Models;
using Microsoft.AspNetCore.Http;

namespace RazorRestaurantApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<MenuItemModel> menuItems {
            get
            {
                return DBInitialize.GetMenus();
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPostAddToCart(string itemID)
        {  
            //add item ids to the session
            var temp = HttpContext.Session.GetString("ItemsInCart");
            if (temp == null) 
            {
                temp = itemID;

            }
            else if (temp.IndexOf(itemID.ToString()) == -1)
            {
                temp+= "," + itemID;
            }
                HttpContext.Session.SetString("ItemsInCart", temp);
      
            Response.Redirect("/Cart?itemID="+ itemID);
        }
    }
}