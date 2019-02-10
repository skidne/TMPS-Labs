namespace Lab1
{
	public interface ISpaceshipFactory
	{
		Spaceship CreateCombatSpaceship(string name);
		Spaceship CreateDefenseSpaceship(string name);
		Spaceship CreateTransportSpaceship(string name);
	}
	
	public class SpaceshipFactory : ISpaceshipFactory
	{
		private SpaceshipManufacturer spaceshipManufacturer;

		public SpaceshipFactory() =>
			spaceshipManufacturer = new SpaceshipManufacturer();

		public Spaceship CreateCombatSpaceship(string name)
		{
			ISpaceshipBuilder builder = new CombatSpaceshipBuilder(name);
			spaceshipManufacturer.Build(builder);
			return builder.Spaceship;
		}

		public Spaceship CreateDefenseSpaceship(string name)
		{
			ISpaceshipBuilder builder = new DefenseSpaceshipBuilder(name);
			spaceshipManufacturer.Build(builder);
			return builder.Spaceship;
		}

		public Spaceship CreateTransportSpaceship(string name)
		{
			ISpaceshipBuilder builder = new TransportSpaceshipBuilder(name);
			spaceshipManufacturer.Build(builder);
			return builder.Spaceship;
		}
	}
}
