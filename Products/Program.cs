List <string> backeryList = new List<string>();
Console.WriteLine(backeryList.Count);

backeryList.Add("Bread");
Console.WriteLine(backeryList.Count);

List<string> chemistry = new List<string>() { "Soap", "Shampoo", "Balsam" };

foreach(string item in chemistry)
{
    Console.WriteLine(item);
}

List<string> vegetables = new() { "Tomatoes", "Cucumbers", "Eggplents" };
vegetables.Add("Carrot");
vegetables.Add("Eggplants");

//vegetables.Sort();
//vegetables.Reverse();

int cucamberIndex = vegetables.IndexOf("Cucumbers");
Console.WriteLine(cucamberIndex);
vegetables.Insert(cucamberIndex, "Lettuce");

vegetables.Remove("Eggplants");
vegetables.RemoveAt(0);


foreach(string veg in vegetables)
{
    Console.WriteLine(veg);
}

Console.WriteLine("___________________");
chemistry.AddRange(vegetables);
foreach(string products in chemistry)
{
    Console.WriteLine(products);
}

Console.WriteLine("___________________");
bool doesChemistryContainsLettuce = chemistry.Contains("Lettuce");
bool doesChemistryContainsCukiny = chemistry.Contains("Cukiny");
Console.WriteLine(doesChemistryContainsLettuce);
Console.WriteLine(doesChemistryContainsCukiny);


List<int> myFavoriteDates = new List<int>() { 2, 8, 13, 21, 30 };
myFavoriteDates.Add(31);
myFavoriteDates.Remove(13);
foreach(int date in myFavoriteDates)
{
    Console.WriteLine(date);
}
