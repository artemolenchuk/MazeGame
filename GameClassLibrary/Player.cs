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
        public int Speed { get; private set; }
        public Direction Direction { get; private set; }

        public Player(int x, int y, int speed, System.Drawing.Image image)
            : base(x, y, image.Width, image.Height, image)
        {
            Speed = speed;
        }

        public void Move(Direction direction)
        {
            Direction = direction;

            int dx = 0;
            int dy = 0;

            switch (direction)
            {
                case Direction.Left:
                    dx = -Speed;
                    break;
                case Direction.Right:
                    dx = Speed;
                    break;
                case Direction.Up:
                    dy = -Speed;
                    break;
                case Direction.Down:
                    dy = Speed;
                    break;
            }

            X += dx;
            Y += dy;
        }
    }
}
