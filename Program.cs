using Raylib_cs;
using shuttle;
using System.IO;
var width = 1200;
var height = 800;
var meship = new Ship(600, 750);

Console.WriteLine("game starting");
Raylib.InitWindow(width, height, "MY MELODY");
var allshots = new List<Shot>();
while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(new Color(0, 0, 0));

    Raylib.DrawRectangleLines(meship.position_X, meship.position_Y, 20, 40, new Color(193, 255, 255));
    Raylib.DrawTexture(meship.texture,600,400,new Color (255,255,255,255));
    Console.WriteLine(File.Exists("/Users/idambuthia/Desktop/Wambui/C SHARP /importing/SHIP.png"));

//fix why the spacip isnt coming

    if (Raylib.IsKeyDown(KeyboardKey.Left) == true)
    {
        Console.WriteLine("LARROW PRESSED");
        meship.movel();
    }

    if (Raylib.IsKeyDown(KeyboardKey.Right) == true)
    {
        Console.WriteLine("RARROW PRESSED");
        meship.mover();
    }

    if (Raylib.IsKeyDown(KeyboardKey.Space) == true)
    {
        //todo:creeate a shot
        var newshot = new Shot(meship.position_X, meship.position_Y);
        allshots.Add(newshot);



    }
    for (int number = 0; number < allshots.Count; number++)
    {

        Raylib.DrawRectangleLines(allshots[number].position_X, allshots[number].position_Y, 10, 20, new Color(255, 255, 255));
        allshots[number].up();
    }


    

































    Raylib.EndDrawing();

}