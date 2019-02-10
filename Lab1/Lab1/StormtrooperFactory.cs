namespace Lab1
{
	public interface IStormtrooperFactory
	{
		IStormtrooper CreateStormtrooper(string identifier,
			string skill, string spec, Spaceship spaceship);
	}

	class StormtrooperFactory : IStormtrooperFactory
	{
		public IStormtrooper CreateStormtrooper(string identifier,
			string skill, string spec, Spaceship spaceship) =>
				new Stormtrooper(identifier, skill, spec, spaceship);
	}
}
