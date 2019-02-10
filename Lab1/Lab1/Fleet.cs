namespace Lab1
{
	public class Fleet
	{
		private static readonly Fleet fleet = new Fleet();

		public ISpaceshipFactory SsFactory { get; }
		public IStormtrooperFactory StFactory { get; }

		private Fleet()
		{
			SsFactory = new SpaceshipFactory();
			StFactory = new StormtrooperFactory();
		}

		public static Fleet GetFleet() => fleet;
	}
}
