using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		
		List<int> numeros = new List<int>();
		
		numeros.Add(1);
		numeros.Add(2);
		numeros.Add(10);
		
		var cities = new List<string>();
		
		cities.Add("Lima");
		cities.Add("Valencia");
		cities.Add("Buenos Aires");
		
		List<string> paises = new List<string>()
		{
			"Brasil",
			"Bolivia",
			"Colombia"
		};
		
		
		Dictionary<int,string>numberNames = new Dictionary<int, string>();
		numberNames.Add(1,"One");
		numberNames.Add(2,"Two");
		numberNames.Add(3,"Three");
		
		foreach(KeyValuePair<int,string>item in numberNames)
		{
			Console.WriteLine($"Clave: {item.Key}, valir: {item.Value}");
		}
		
	}
}


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//HErencia y polimorfismo
using System;
using System.Collections.Generic;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		var shapes = new List<Shape>();
		var rectangle = new Rectangle(){Width=20, Height = 10};
		var triangle = new Triangle(){Width=10, Height = 15};
		var Square = new Square(){Width=10};
		
		shapes.Add(rectangle);
		shapes.Add(triangle);
		shapes.Add(Square);
		
		foreach(var item in shapes)
			Console.WriteLine(item.CalculateArea());
	}
}

public abstract class Shape{
	public int Height {get; set;}
	public int Width {get; set;}
	public abstract double CalculateArea();
}

public class Square:Shape{
	public override double CalculateArea(){
		return Math.Pow(Width, 2);
	}
}

public class Rectangle:Shape{
	public override double CalculateArea(){
		return Width*Height;
	}
}

public class Triangle:Shape{
	public override double CalculateArea(){
		return (Width*Height)/2;
	}
}


