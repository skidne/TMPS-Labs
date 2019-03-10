using Labs;
using System;
using System.Collections.Generic;

namespace Client
{
	public class Program
	{
		public static Random rand = new Random();

		public static void Main(string[] args)
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

			Console.WriteLine("Creational Patterns (Lab1):");
			Console.WriteLine("Spaceships:");
			spaceships.ForEach(x => Console.WriteLine(x.ToString()));
			Console.WriteLine("Stormtroopers:");
			stormtroopers.ForEach(x => Console.WriteLine(x.ToString()));

			Console.WriteLine("\nStructural Patterns (Lab2):");
			spaceships.ForEach(x => {new SpaceshipFlightFacade(x).StartFlight(rand.NextDouble() >= 0.5);});

			stormtroopers[0].Fight(new StormtrooperFighting(new RangeWeapon()));
			stormtroopers[1].Fight(new StormtrooperFighting(new MeleeToRangeAdapter(new MeleeWeapon())));
			stormtroopers[2].Fight(new StormtrooperSpecialAttackDecorator(new StormtrooperFighting(new RangeWeapon())));
			Console.ReadKey();
		}
	}
}
