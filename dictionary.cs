var hero=new Dictionary<string,string>();
hero.Add("name","superman");
hero.Add("power","fly");
hero.Add("weakness","coffee");
//geting an item from dictionary

Console.WriteLine(hero["name"]);

//changing an item
hero["power"]="strength";

Console.WriteLine(hero["power"]);

//adding an item (option 2)

hero["hobby"]="skating";

Console.WriteLine(hero["hobby"]);

//removing an item

hero.Remove("name");

//Console.WriteLine(hero["name"]);

Console.WriteLine("-----=-------------=-----------=-----------=--------------------=-------------=-------=------------=-----------=");

var vehicle=new Dictionary<string,string>();
vehicle.Add("brand","mercedes");
vehicle.Add("type","g wagon");
vehicle.Add("colour","black");
vehicle.Add("topspeed","450km/p");
vehicle.Add("owner","wambui");

foreach(var pair in vehicle)
{
  Console.WriteLine(pair);
};








