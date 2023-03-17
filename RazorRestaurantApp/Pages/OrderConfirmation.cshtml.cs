using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurantApp.Models;

namespace RazorRestaurantApp.Pages
{
    public class OrderConfirmationModel : PageModel
    {
        public void OnGet(string orderID)
        {
            //version2: Design a detailed confirmation page with name and address of the customer
            ViewData["orderID"] = orderID;
        }
    }
}
