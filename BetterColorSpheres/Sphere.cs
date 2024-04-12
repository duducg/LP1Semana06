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
        //values by omission only work in auto implement properties 
        public int TimesTrown { get; private set; }

        public Sphere (Color color,float raio)
        {
            Color = color;
            Raio = raio;
            //private set is needed to allow access to the rest of the code
            //not the constructor
            TimesTrown = 0;                  
        } 
        public void Pop()
        {
            raio = 0;
        }
        public void Throw()
        {
            if (Raio > 0)
            {
                //private set is needed to allow access to the rest of the code
                //not the constructor
                TimesTrown++;   
            }            
        }
        
    }
}