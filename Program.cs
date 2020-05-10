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
	    private int rok_produkcji;
	    private string color;
	    public Car(string marka, string model, int rok_produkcji, string color)
	    {
	    	this.marka = marka;
		this.model = model;
		this.rok_produkcji = rok_produkcji;
		this.color = color;
	    }
	    /*
	     *   Konstruktor do tworzenia obiektu samochod, ktory jest czerwonym Fordem
	     *
	     */
	    public Car(string model){
	    	this.model = model;
		marka = "Ford";
		color = "czerwony";
		rok_produkcji = 2020;
	    }
	    public Car(){
                marka = "Fiat";
    		model = "500";
		color = "czerwony";
 		rok_produkcji = 2002;
	    }
	    public string Napisz(){
		    return color + " " + marka + " " + model+ " " + rok_produkcji;
	    }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
             var a = 5;
	     var b = 3;
	     var punkt = new Point();
	     var pierwszy_samochod = new Car("Ford", "Fiesta", 89, "zielony");
	     punkt.Hello();
	     Console.WriteLine("moj pierwszy samochod to: " + pierwszy_samochod.Napisz());
	     punkt.x = 3;
	     punkt.y = 7;
	     Console.WriteLine("Hello World! "+ (a+b)+" "+ punkt.Napisz());
        }
    }
}
