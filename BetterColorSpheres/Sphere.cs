using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public float Raio  { get; private set; }
        public int TimesTrown { get; private set; } = 0;

        public Sphere (Color color,float raio)
        {
            Color = color;
            Raio = raio;                   
        } 
        public void Pop()
        {
            Raio = 0;
        }
        public void Throw()
        {
            if (Raio > 0)
            {
                TimesTrown++;   
            }            
        }
        
    }
}