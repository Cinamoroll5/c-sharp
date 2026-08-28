using Raylib_cs;
using Circle;
var width=1200;
var height=800;
double gravity=0.001;
var b1=new Ball(10,162, 223, 246,600,400,0,0);

var ballb=new List<Ball>();

var rand=new Random();


Raylib.InitWindow(width, height,"CINAMONROLL");
while (Raylib.WindowShouldClose()==false)
{
     Raylib.BeginDrawing();
     Raylib.ClearBackground(new Color(0,0,0));
    
     if (Raylib.IsMouseButtonPressed(0)==true)
     {
          Console.WriteLine("MEEEEE CLICK");
          //TODO:CREATE CIRCLE
          var b2=new Ball((rand.Next(10,50)),rand.Next(0,255), rand.Next(0,255),rand.Next(0,255),Raylib.GetMouseX(),Raylib.GetMouseY(),rand.Next(-5,5)*0.1
          ,0);
          ballb.Add(b2);
          Console.WriteLine(ballb.Count);
     }

     if(ballb.Count>0)
     {
          for(int num=0;num<ballb.Count;num+=1)
     {
     Raylib.DrawCircle((int)ballb[num].position_X,(int)ballb[num].position_Y,ballb[num].size,new Color(ballb[num].r, ballb[num].g, ballb[num].b));
     ballb[num].speed_Y+=gravity;
     ballb[num].position_Y+=ballb[num].speed_Y;
     ballb[num].position_X+=ballb[num].speed_X;

     if (ballb[num].position_Y>800)
     {
          
          ballb[num].position_Y=799;
          ballb[num].speed_Y=-ballb[num].speed_Y*rand.Next(0,10)*0.1;
     }

     if (ballb[num].position_X>1200)
     {
          ballb[num].position_X=1199;
          ballb[num].speed_X=-ballb[num].speed_X*0.1;
     }
     
     if (ballb[num].position_X<0)
     {
          ballb[num].position_X=1;
          ballb[num].speed_X=-ballb[num].speed_X*0.1;
     }


     }
     }
     Raylib.EndDrawing();
}