using System;
using System.Collections.Generic;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			var fleet = CommandCenter.Instance.Fleet;
			var spaceshipFactory = fleet.GetSpaceshipFactory();
			var stormtrooperFactory = fleet.GetStormtrooperFactory();

			var spaceships = new List<Spaceship>
			{
				spaceshipFactory.CreateSpaceship("Dreadnaught SSV", SpaceshipType.Combat),
				spaceshipFactory.CreateSpaceship("Space Star V", SpaceshipType.Defense),
				spaceshipFactory.CreateSpaceship("Carrier Vispa", SpaceshipType.Transport)
			};

			var stormtrooper1 = stormtrooperFactory
				.CreateStormtrooper("Jango Fett", spaceships[1]);
			var stormtrooper2 = stormtrooperFactory
				.CreateStormtrooper("Pepe", spaceships[0]);
			var stormtrooper3 = stormtrooperFactory
				.CreateStormtrooper("Kermit", spaceships[2]);

			var stormtroopers = new List<IStormtrooper>
			{
				stormtrooper1.Clone(),
				stormtrooper2.Clone(),
				stormtrooper3.Clone(),
				stormtrooper1.Clone()
			};

			Console.WriteLine("Spaceships:");
			spaceships.ForEach(x => Console.WriteLine(x.ToString()));
			Console.WriteLine("Stormtroopers:");
			stormtroopers.ForEach(x => Console.WriteLine(x.ToString()));
			Console.ReadKey();
		}
	}
}
