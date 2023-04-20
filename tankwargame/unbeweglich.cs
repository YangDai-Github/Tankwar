using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tankwargame
{
    class unbeweglich:GameObject
    {
        private Image img;
        public Image Img { get { return img; } 
            set { 
                img = value;
                Width = img.Width;
                Height = img.Height;
            } 
        }

        protected override Image GetImage()
        {
            return Img;
        }

        public unbeweglich(int x,int y,Image img)
        {
            this.X = x;
            this.Y = y;
            this.Img = img;
        }
    }
}
