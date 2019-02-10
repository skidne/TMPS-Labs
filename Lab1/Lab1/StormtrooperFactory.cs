namespace Lab1
{
	public interface IStormtrooperFactory
	{
		IStormtrooper CreateStormtrooper(string id, string sk, string sp, Spaceship s);
	}

	class StormtrooperFactory : IStormtrooperFactory
	{
		public IStormtrooper CreateStormtrooper(string id, string sk, string sp, Spaceship s) =>
			new Stormtrooper(id, sk, sp, s);
	}
}
