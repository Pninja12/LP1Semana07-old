using System;

namespace FillSpheres
{
    public class Color
    {
        byte red;
        byte green;
        byte blue;
        byte alpha;

        public Color(byte _red,byte _green,byte _blue, byte _alpha)
        {
            red = _red;
            green = _green;
            blue = _blue;
            alpha = _alpha;
        }

        public Color(byte _red,byte _green,byte _blue)
        {
            red = _red;
            green = _green;
            blue = _blue;
            alpha = 255;
        }

        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }
        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }

        public void GetGrey(byte red, byte green, byte blue)
        {
            int grey = (red + green + blue) / 3;
            Console.Write(grey);
        }
    }

    public class Sphere
    {
        int[] cor = new int[4];
        float raio;
        int nvezes;

        public Sphere(byte _red, byte _green, byte _blue, byte _alpha, float _raio, int _nvezes)
        {
            cor[0] = _red;
            cor[1] = _green;
            cor[2] = _blue;
            cor[3] = _alpha;

            raio = _raio;
            nvezes = _nvezes;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio > 0)
            {
                nvezes++;
            }
        }

        public void GetTimesThrown()
        {
            Console.Write(nvezes);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
