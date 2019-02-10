namespace Lab1
{
	public interface IStormtrooperFactory
	{
		IStormtrooper CreateSandtrooper(string id, Spaceship s);
		IStormtrooper CreateDeathtrooper(string id, Spaceship s);
		IStormtrooper CreateScouttrooper(string id, Spaceship s);
	}

	class StormtrooperFactory : IStormtrooperFactory
	{
		public IStormtrooper CreateDeathtrooper(string id, Spaceship s) =>
			new Deathtrooper(id, s);

		public IStormtrooper CreateSandtrooper(string id, Spaceship s) =>
			new Sandtrooper(id, s);

		public IStormtrooper CreateScouttrooper(string id, Spaceship s) =>
			new Scouttrooper(id, s);
	}
}
