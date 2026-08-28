List<string> planets=new List<string>();
planets.Add("mercury");
planets.Add("venus");
planets.Add("earth");
planets.Add("mars");
planets.Add("jupiter");
planets.Add("saturn");
planets.Add("uranus");
planets.Add("neptune");
Console.WriteLine(planets[0]);
List<int>exams=new List<int>();
exams.Add(100);
exams.Add(99);
exams.Add(98);
Console.WriteLine(exams[2]);



//short way
var food=new List<string>();
food.Add("mochi");
food.Add("cinamonroll");
food.Add("ice cream");
Console.WriteLine(food[1]);


//repeat blocks

//start        stop       step
for(int number=0; number<8;number+=1)
{ 
  Console.WriteLine(planets[number]);
};

Console.WriteLine("-----------------------------------------------------------------------------------");

//change an item in a list
food[0]="macaroni";
Console.WriteLine(food[0]);

//how to remove an item in a list

//WAY 1

planets.Remove("saturn");
  for(int number=0; number<7;number+=1)
{ 
  Console.WriteLine(planets[number]);
};

Console.WriteLine("----------------------------------------------------------------------------------");

//WAY 2

planets.RemoveAt(1);
 for(int number=0; number<7;number+=1)
{ 
  Console.WriteLine(planets[number]);
};