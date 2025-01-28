using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class Finish : GameObject
    {
        public Finish(int x, int y, int width, int height, Image image) : base(x, y, width, height, image)
        {

        }

        public bool IsPlayerOnFinish(Player player)
        {
            Rectangle playerBounds = new Rectangle(player.X, player.Y, player.Width, player.Height);
            Rectangle finishBounds = new Rectangle(X, Y, Width, Height);
            return playerBounds.IntersectsWith(finishBounds);
        }
    }
}
