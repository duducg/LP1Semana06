using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        private float raio;
        public float Raio  { get; private set; }
        private int timesTrown;
        public int TimesTrown { get; private set; } = 0;

        public Sphere (Color color,float raio)
        {
            Color = color;
            Raio = raio;                   
        } 
        public void Pop()
        {
            raio = 0;
        }
        public void Throw()
        {
            if (raio > 0)
            {
                TimesTrown++;   
            }            
        }
        
    }
}