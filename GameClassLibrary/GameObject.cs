using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public System.Drawing.Image Image { get; set; }

        public GameObject(int x, int y, int width, int height, System.Drawing.Image image)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Image = image;
        }
    }
}
