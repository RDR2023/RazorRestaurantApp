# RazorRestaurantApp
Pizaa Project to learn Razor Pages

## Asp.Net MVC Web Project using Razor Pages

### Concept
  It's a simple shopping cart project. A set of delicious Pizza are available for the user to order. There is no pay system implemented. 
  User gets to add his favorite Pizza to the cart. The page is then redirected to the Cart page. User gets to enter his name,address, email and
  when he clicks on the place my order, an order is placed and then redirected to the thank you page.
  
### Models
 The following Models were created to handle data in the project
 
 1. MenuItemModel - holds the details of each type of Pizza available to order
 2. CustomerModel - holds the customer information
 3. OrdersModel - holds the order infromation placed by the customer
 4. CartItemsModel - holds the pizza details added to cart
  
### To Do
 EntityFramework work is to implemented to store data to Database
 
### Technical Limitations/flaws in the current version
 1. A session object is used to hold the item ids, that were added to cart.
 2. Objects are floating in memory and they need to be stored in DB

 
