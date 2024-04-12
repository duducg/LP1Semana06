using System;
using System.Collections.Generic;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the colo sphere class
            Color black = new Color(0, 0, 0); //black
            Color white = new Color(255, 255, 255, 255); //white
            Color red = new Color(255, 0, 0); //red
            Color green = new Color(0, 255, 0); //green
            Color blue = new Color(0, 0, 255, 255); //blue
            Color dunno = new Color(255, 255, 0, 135);

            //balls
            Sphere s1 = new Sphere(black, 2f);
            Sphere s2 = new Sphere(dunno, 4.5f);
            Sphere s3 = new Sphere(black, 4f);
            Sphere s4 = new Sphere(red, 10f);
            Sphere s5 = new Sphere(black, 3f);
            Sphere s6 = new Sphere(blue, 2.1f);
            
            //trow some balls at random:
            Random random = new Random();
            List<Sphere> sphereList = new List<Sphere>();
            sphereList.Add(s1); 
            sphereList.Add(s2); 
            sphereList.Add(s3); 
            sphereList.Add(s4); 
            sphereList.Add(s5); 
            sphereList.Add(s6); 

            //pop random
            foreach(Sphere sphere in sphereList)
            {
                if(random.Next(6) == 1)
                    {
                        sphere.Pop();
                    }

            }
            
            //trow random
            for (int i = 0; i < 10;i++)
            {
                foreach(Sphere sphere in sphereList)
                {
                    if(random.Next(2) == 1)
                    {
                        sphere.Throw();
                    }
                
                }
            }
            //print spheres
            foreach(Sphere sphere in sphereList)
            {
                int index_ = sphereList.IndexOf(sphere);
                int trown = sphere.GetTimesThrown();
                string out_ = $"Sphere {index_} trown: {trown}";
                Console.WriteLine(out_);
            }
            

            

            



        }
    }
}
