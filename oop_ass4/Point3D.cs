using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass4
{
    internal class Point3D : IComparable
    {
       

        public double Dim01 {  get; set; }
        public double Dim02 { get; set; } 
        public double Dim03 { get; set; }

       
       

        public Point3D(double dim01, double dim02, double dim03)
        {
            Dim01 = dim01;
            Dim02 = dim02;
            Dim03 = dim03;
        }
        public override string ToString()
        {
            return $"Point coordinates: ({Dim01} ,{Dim02},{Dim03})";

        }

       

        public int CompareTo(object? obj)
        {
            Point3D p = (Point3D)obj;
            if (this.Dim01 > p.Dim01 && this.Dim02 > p.Dim02) return 1;
            else if (this.Dim01 < p.Dim01 && this.Dim02 < p.Dim02) return -1;
            else return 0;
        }
    }
}
