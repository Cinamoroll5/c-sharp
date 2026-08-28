int total()
{
return 5+6;
};
 int answer=total();
 Console.WriteLine(answer);

string myname()
 {
    return "Wambui🍦🧋";

 };
 string nameof=myname();
 Console.WriteLine(nameof);




 //You found a treasure chest on a distant planet! But the gold is split between two separate bags. We need a method that adds
 //  them together so you know your total wealth.

//The Mission: Create a method called CalculateGold.
//The Arguments: Two integers: int bagOne and int bagTwo.
//The Logic: Add bagOne and bagTwo together and return the total.
//Check Your Work: Save the result in a variable called totalGold and then 
//Console.WriteLine("Total treasure collected: " + totalGold + " coins!");

int totalGold(int bagOne,int bagTwo)
{
   return bagOne+bagTwo;
};
int rich=totalGold(55,77);
Console.WriteLine("Total treasure collected: " +rich + " coins!");


//homework
//try challange 2 and if u feel confident do 3.

//📦 Mission 2: The Robot Speed Boost
//Your racing robot needs a speed boost for the final lap! 
//We need a method that takes its base speed and adds the turbo boost power to it.

//The Mission: Create a method called ApplyTurbo.
//The Arguments: Two integers: int baseSpeed and int turboBoost.
//The Logic: Add baseSpeed and turboBoost together and return the new speed.
//Check Your Work: Save the result in a variable called finalSpeed and then 
//Console.WriteLine("Robot speed increased to: " + finalSpeed + " km/h!");


int ApplyTurbo(int baseSpeed,int turboBoost)
{
   return baseSpeed+turboBoost;

};
int finalSpeed=ApplyTurbo(6,7);
Console.WriteLine("Robot Speed Increased To: "+ finalSpeed+"km/h!!!");



//📦 Mission 3: The Magical Potion Mixer
//To finish your level, you need to mix ingredients for a health potion. 
//The method should calculate the total amount of "Magic Energy" based on two jars of ingredients.

//The Mission: Create a method called MixPotion.
//The Arguments: Two integers: int jarOneEnergy and int jarTwoEnergy.
//The Logic: Add jarOneEnergy and jarTwoEnergy together and return the final energy level.
//Check Your Work: Save the result in a variable called totalEnergy and then
// Console.WriteLine("The potion is ready with " + totalEnergy + " units of magic!");


int MixPotion(int jarOneEnergy,int jarTwoEnergy)
{
   return jarOneEnergy+jarTwoEnergy;
};
 int totalEnergy=MixPotion(67,67);
 Console.WriteLine("the potion is ready with "+totalEnergy+" units of magic");









