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

			var defaultSandTrooper = stormtrooperFactory
				.CreateStormtrooper("Azaz", "is usually found on Tatooine.",
				"Sandtrooper", spaceships[1]);
			var defaultDeathTrooper = stormtrooperFactory
				.CreateStormtrooper("Pipi", "is very dangerous. Much Ouch.",
				"Deathtrooper", spaceships[0]);
			var defaultScouttrooper = stormtrooperFactory
				.CreateStormtrooper("Kermit", "has recon and survival skills.",
				"Scouttrooper", spaceships[2]);

			var stormtroopers = new List<IStormtrooper>
			{
				defaultSandTrooper.Clone(),
				defaultDeathTrooper.Clone(),
				defaultScouttrooper.Clone(),
				defaultDeathTrooper.Clone()
			};

			Console.WriteLine("Spaceships:");
			spaceships.ForEach(x => Console.WriteLine(x.ToString()));
			Console.WriteLine("Stormtroopers:");
			stormtroopers.ForEach(x => Console.WriteLine(x.ToString()));
			Console.ReadKey();
		}
	}
}
