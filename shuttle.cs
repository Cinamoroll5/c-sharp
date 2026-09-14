using Raylib_cs;
namespace shuttle
{
    class Ship
    {

        public int position_X;
        public int position_Y;
        public Texture2D texture;
        //theheheheheheeh constructoyrrrr

        public Ship(int position_X, int position_Y)
        {

            this.position_X = position_X;
            this.position_Y = position_Y;

            var image=Raylib.LoadImage("/Users/idambuthia/Desktop/Wambui/C SHARP /importing/SHIP.png");
            this.texture=Raylib.LoadTextureFromImage(image);

        }
        public void movel()
        {
            this.position_X -= 1;
            if (this.position_X < 0)
            {
                this.position_X = 1199;
            }
        }

        public void mover()
        {
            this.position_X += 1;
            if (this.position_X > 1200)
            {
                this.position_X = 1;
            }
        }




    }


    class Shot
    {
        public int position_X;
        public int position_Y;

        //theeeee constructorrr

        public Shot(int position_X, int position_Y)
        {
            this.position_X = position_X;
            this.position_Y = position_Y;
        }

public void up()
{
this.position_Y-=1;
}


    }


    class Enemy
    {

        public int position_X;
        public int position_Y;

        //theeeeeee constructorrrrr

        public Enemy(int position_X, int position_Y)
        {
            this.position_X = position_X;
            this.position_Y = position_Y;
        }
    }
}