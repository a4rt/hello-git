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
