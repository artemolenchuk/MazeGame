using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace GameClassLibrary
{
    public class Player : GameObject
    {
        public Player(int x, int y, int speed, System.Drawing.Image image) : base(x, y, image.Width, image.Height, image)
        {
            Speed = speed;
        }

        public int Speed { get; set; }
        public Direction Direction { get; set; }

        public void MoveLeft()
        {
            X -= Speed;
            Direction = Direction.Left;
        }

        public void MoveRight()
        {
            X += Speed;
            Direction = Direction.Right;
        }

        public void MoveUp()
        {
            Y -= Speed;
            Direction = Direction.Up;
        }

        public void MoveDown()
        {
            Y += Speed;
            Direction = Direction.Down;
        }
    }
}
