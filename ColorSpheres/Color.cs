using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

        }
        //Constructor overload that set alpha to 255
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;

        }
        //Getter methods for variables
        public byte getRed()
        {
            return red;
        }
        public byte getGreen()
        {
            return green;
        }
        public byte getBlue()
        {
            return blue;
        }
        public byte getAlpha()
        {
            return alpha;
        }

        public byte getGrey()
        {
            int result = (red + green + blue) / 3;
            return (byte)result;
        }

    }

    


}