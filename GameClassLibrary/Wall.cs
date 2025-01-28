using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace GameClassLibrary
{
    public class Wall : GameObject
    {
        public Wall(int x, int y, int width, int height, System.Drawing.Image image) : base(x, y, width * 2, height * 2, image)
        {

        }
    }
}
