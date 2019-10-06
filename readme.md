USER STORIES COMPLETED
======================
(Out of 105 points) 

As a developer, if I don’t know what Lemonade Stand game is, I will play the game online for a bit to get familiar with the gameplay.

(5 points): As a developer, I want to make good, consistent commits.

(25 points): As a player, I want the basic Lemonade Stand gameplay to be present.

(10 points): As a player, I want a weather system that includes a forecast and actual weather, so that I can get a predicted forecast for a day or week and then what the actual weather is on the given day.

(10 points): As a player, the price of product as well as weather/temperature should affect demand, so that if the price is too high, sales will decrease, or if the price is too low, sales will increase, etc. 

(10 points): As a player, I want each customer to be a separate object with its own chance of buying a glass of lemonade, so that how much lemonade is purchased and how much a customer is willing to pay will vary from customer to customer.

(5 points): As a player, I want the ability to make a recipe for my lemonade, so thatI can include x-amount of lemons, x-amount of sugar, and x-amount of ice. 

(10 points): As a player, I want my game to be playable for at least seven days.

(10 points): As a player, I want my daily profit or loss displayed at the end of each day, so that I know how much money my lemonade stand has made. I also want my total profit or loss to be a running total that is displayed at the end of each day, so that I know how much money my lemonade stand has made. 

(10 points): As a developer, I want to implement the SOLID design principles as well as C# best practices in my project, so that the project is as well-designed as possible.

(10 points (5 points each)): As a developer, I want to pinpoint at least two placeswhere I used one of the SOLID design principles and discuss my reasoning, so that I can properly understand good code design. Minimum of two SOLID design principles must be used. (See Below)

SOLID PRINCIPLES DEMONSTRATED IN THIS PROJECT
=============================================

The *Single Respensibility Principle* is demonstrated throughout the project as I tended away from larger functions and focused on smaller functions that did one thing very well. One example would be the "IsEnoughInventory" function in my [Inventory class](https://github.com/gabrielkunkel/LemonadeStand/blob/master/LemonadeStand/Inventory.cs). It's a check that could have been included with a number of other functions. It could even be added to a class where it is used, like the Day class, but the Inventory class takes responsibility for the values that concern the Lemonade Stand's inventory.

Using the *Dependency Inversion Principle* I decoupled the creation of Customers from where they are processed with logic in the Day class, by creating a [CustomerFactory](https://github.com/gabrielkunkel/LemonadeStand/blob/master/LemonadeStand/CustomerFactory.cs). The CustomerFactory class permits me to avoid modifying the [Day class](https://github.com/gabrielkunkel/LemonadeStand/blob/master/LemonadeStandConsole/Day.cs) it's called in. Day class and Customer Factory now depend on the interface, the abstraction, [ICustomer](https://github.com/gabrielkunkel/LemonadeStand/blob/master/LemonadeStand/ICustomer.cs). If I was doing this again I would make CustomerFactory a static class, so Day wouldn't have to instantiate it. In the future my factory classes will be static.