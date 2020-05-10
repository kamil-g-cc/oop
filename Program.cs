using System;

namespace oop
{
    public struct Point
    {
	  public double x;
	  public double y;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
             var a = 5;
	     var b = 3;
	     var punkt = new Point();
	     punkt.x = 3;
	     punkt.y = 7;
	     Console.WriteLine("Hello World! "+ (a+b)+" ("+punkt.x+","+punkt.y+")");
        }
    }
}
