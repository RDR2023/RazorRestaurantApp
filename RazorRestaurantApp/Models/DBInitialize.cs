namespace RazorRestaurantApp.Models
{
    public class DBInitialize
    {
        
        public static IList<MenuItemModel> GetMenus()
        {
            List<MenuItemModel> menu = new List<MenuItemModel>  
            {
            new MenuItemModel()
            {
                ID=1,
                ItemImagePath = "Margerita.png",
                ItemName = "Margerita Pizza",
                ItemDescription = "Pizza with tomato sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 35
            },
            new MenuItemModel()
            {
                ID=2,    
                ItemImagePath = "Bolognese.png",
                ItemName = "Bolognese Pizza",
                ItemDescription = "Pizza with bolognese sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 4
            },
            new MenuItemModel()
            {
                ID=3,
                ItemImagePath = "Carbonara.png",
                ItemName = "Carbonara Pizza",
                ItemDescription = "Pizza with carbonara sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 4
            },
            new MenuItemModel()
            {
                ID=4,
                ItemImagePath = "Hawaiian.png",
                ItemName = "Hawaiian Pizza",
                ItemDescription = "Pizza with fresh juicy tomatoes,peppers and cheese",
                TomatoSauce = true,
                Cheese = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 8
            },
            new MenuItemModel()
            {
                ID=5,
                ItemImagePath = "Vegetarian.png",
                ItemName = "Vegetable Pizza",
                ItemDescription = "Pizza with fresh vessgies like onions,pepers,mushrooms,tomato sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 6
            },
            new MenuItemModel()
            {
                ID=6,
                ItemImagePath = "Seafood.png",
                ItemName = "Seafood Pizza",
                ItemDescription = "Pizza with tuna,shrimp,salmon,tomato1 sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                Tuna = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 14
            },
            new MenuItemModel()
            {
                ID=7,
                ItemImagePath = "Mushroom.png",
                ItemName = "Mushroom Pizza",
                ItemDescription = "Pizza with mushroom,tomato sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 5
            },
            new MenuItemModel()
            {
                ID =8,
                ItemImagePath = "Pepperoni.png",
                ItemName = "Pepperoni Pizza",
                ItemDescription = "Pizza with Pepperoni, tomato sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                Peperoni = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 5
            },
            new MenuItemModel()
            {
                ID=9,
                ItemImagePath = "MeatFeast.png",
                ItemName = "MeatFeast Pizza",
                ItemDescription = "Pizza with chicken,tomato sauce and cheese",
                TomatoSauce = true,
                Cheese = true,
                ItemBasePrice = 2,
                ItemFinalPrice = 6
            },
            };

            return menu;
        }

        public static string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static void AddItemsToCart()
        {

        }

    }
}
