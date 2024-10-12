
string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

string randomMovie = PickRandomFromArray(tvShows);
string randomFood = PickRandomFromArray(food);
string randomDrink = PickRandomFromArray(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight");
Console.WriteLine($"Order some {randomFood} and {randomDrink}.");


PickRandomFromArray(tvShows);
PickRandomFromArray(food);
PickRandomFromArray(drinks);

static string PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();

    int randomIndex = rnd.Next(0, someArray.Length);
    string randomElement = someArray[randomIndex];
    return randomElement;
}