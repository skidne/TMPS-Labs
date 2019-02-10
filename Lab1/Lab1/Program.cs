using System;
using System.Collections.Generic;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			var fleet = Fleet.GetFleet();
			var spaceshipFactory = fleet.SsFactory;
			var stormtrooperFactory = fleet.StFactory;

			var spaceships = new List<Spaceship>
			{
				spaceshipFactory.CreateCombatSpaceship("Dreadnaught SSV"),
				spaceshipFactory.CreateDefenseSpaceship("Space Star V"),
				spaceshipFactory.CreateTransportSpaceship("Carrier Vispa")
			};

			var defaultSandTrooper = stormtrooperFactory
				.CreateSandtrooper("Azaz", spaceships[1]);
			var defaultDeathTrooper = stormtrooperFactory
				.CreateDeathtrooper("Pipi", spaceships[0]);
			var defaultScouttrooper = stormtrooperFactory
				.CreateScouttrooper("Kermit", spaceships[2]);

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
