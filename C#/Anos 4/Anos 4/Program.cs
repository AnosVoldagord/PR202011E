using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anos_4
{
    class Program
    {
        
    }
    interface IMath
    {
        void Area();
    }
    class Circle:IMath
    {
        public const float PI = 3.14F;
        protected float Radius;
        protected double AreaOfCircle;
        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }
    class Sphere:Circle
    {
        double AreaOfSphere;
        public override void Area()
        {
            base.Area();
            AreaOfSphere = (AreaOfCircle * 4);
        }
        static void Main(string[] args)
        {
            Sphere obj = new Sphere();
            obj.Radius = 7;
            obj.Area();
            Console.WriteLine("Area Of Sphere:{0:F2}",obj.AreaOfSphere);
        }
    }
}
