using System;

namespace oop
{
    public struct Point
    {
	  public double x;
	  public double y;
	  public string Napisz(){
	       return "(" + x + "," + y + ")";
	  }
	  public void Hello(){
	       Console.WriteLine("Hello!");
	  }
    }

    public class Car
    {
	    private string marka;
	    private string model;
	    public Car(string marka, string model, int rok_produkcji){
	    	this.marka = marka;
		this.model = model + rok_produkcji;
	    }
	    public string Napisz(){
		    return marka + " " + model;
	    }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
             var a = 5;
	     var b = 3;
	     var punkt = new Point();
	     var pierwszy_samochod = new Car("Ford", "Fiesta", 89);
	     punkt.Hello();
	     Console.WriteLine("moj pierwszy samochod to: " + pierwszy_samochod.Napisz());
	     punkt.x = 3;
	     punkt.y = 7;
	     Console.WriteLine("Hello World! "+ (a+b)+" "+ punkt.Napisz());
        }
    }
}
