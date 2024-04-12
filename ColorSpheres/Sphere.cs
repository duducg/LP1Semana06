using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        private int timesTrown;

        public Sphere (Color color,float raio)
        {
            this.color = color;
            this.raio = raio;
            timesTrown = 0;        
        } 
        public void Pop()
        {
            raio = 0;
        }
        public void Throw()
        {
            if (raio > 0)
            {
                timesTrown++;   
            }            
        }
        public int GetTimesThrown()
        {
            return timesTrown;
        }
    }
}