void sayhi()
{
    Console.WriteLine("----------------------------------------------------------------------------------");
    Console.WriteLine("helllo from aliens");
};
sayhi();

void add(int a, int b)
{
    Console.WriteLine(a+b);
};
add( 46,65);

void pizza(string toppings)
{
   Console.WriteLine("HERE IS YOUR PIZZAA 🍕 WITHHHHHHH..."+toppings);
};
pizza("ham,peporoni,pinapple,cheese_alot,sauce,sausage");


//🚨 The Perimeter Alarm 🚨
//The Mission: 
//The zombies are getting close! 
//We need an alarm that we can trigger anytime just by calling its name.
// Create a function called soundAlarm. Inside the function, make it print "WARNING: ZOMBIES AT 
//THE GATE!" to the console and print "RUN TAKE YOUR BAGS!".
//Check your work: Call your function once at the bottom of your code to make sure the alarm
// actually rings!


void alarm()
{
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine("WARNING: ZOMBIES AT THE GATE");
        Console.WriteLine("RUN AND TAKE YOUR BAGS");
};
alarm();






//🕺 The Victory Dance 🕺
//The Mission: You survived the night! To celebrate, you need a function that performs a 
//three-step dance. Create a function called victoryDance. Inside the function, use three 
//different console.log lines to print:

//"Slide to the left!"
//"Spin around!"
//"Moonwalk!"
//Check your work: Call the victoryDance() function. You should see all three moves appear in 

// the console in the right order!

void victoryDance()
{
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine("slide to the left");
    Console.WriteLine("slide to the right");
    Console.WriteLine("now do the moonwalk");
        Console.WriteLine("-----------------------------------------------------------------");
};
victoryDance();


//🚀 Mission 3: The Robot Guard-Dog
//You’ve built a robot dog to distract the zombies. You need to be able to tell it which
// direction to run and how fast to go.

//The Task: Create a function called distractZombies.
//The Arguments: Use two arguments: direction and speed.
//The Logic: Print a message that says: 
//"Robot Dog is sprinting " + direction + " at " + speed + " miles per hour!".
//Check Your Work: Call the function and tell the dog to go "North" at "25" mph.
 
void distractzombies(string direction,int speed)
{
   Console.WriteLine("--------------------------------------------------------");
   Console.WriteLine("robot is sprinting "+direction+" at "+speed+" miles per hour");
};
distractzombies("east",100000);









//🥗 Mission 2: The Ration Report
//We need to keep track of our supplies! Instead of doing heavy math, let's make a function that just 
//announces how long the survivors will be eating.

// The Task: Create a function called calculateRations.

// The Arguments: Give it two arguments: survivors and days.

//The Logic:
// Inside the function, make it print: "Feeding " + survivors + " survivors for " + days + " days!".

//Check Your Work: Call the function with the numbers 5 and 7.

void  calculateRations(int survivors,int days)
{
    Console.WriteLine("---------------------------------------------------------------------------------------------------------");
    Console.WriteLine("FEEDING "+survivors+" survivors for "+days+" days🍦🧋");
};
calculateRations(5,7);


