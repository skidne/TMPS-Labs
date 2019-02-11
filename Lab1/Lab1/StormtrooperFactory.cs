namespace Lab1
{
	public interface IStormtrooperFactory
	{
		IStormtrooper CreateStormtrooper(string identifier, Spaceship spaceship);
	}

	class StormtrooperFactory : IStormtrooperFactory
	{
		public IStormtrooper CreateStormtrooper(string identifier, Spaceship spaceship) =>
				new Stormtrooper(identifier, spaceship);
	}
}
