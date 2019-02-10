namespace Lab1
{
	public interface ISpaceshipFactory
	{
		Spaceship CreateSpaceship(string name, SpaceshipType type);
	}
	
	public class SpaceshipFactory : ISpaceshipFactory
	{
		public Spaceship CreateSpaceship(string name, SpaceshipType type)
		{
			ISpaceshipBuilder builder = new SpaceshipBuilder(name);

			switch (type)
			{
				case SpaceshipType.Combat:
					builder.BuildFuselage(Fuselage.SemiMonocoque);
					builder.BuildEngines(Engines.Photonic);
					builder.BuildAvionics(Avionics.Rockwell);
					builder.BuildWeaponry(Weaponry.Missile);
					return builder.BuildSpaceship();

				case SpaceshipType.Defense:
					builder.BuildFuselage(Fuselage.Monocoque);
					builder.BuildEngines(Engines.Quantum);
					builder.BuildAvionics(Avionics.Bendix);
					builder.BuildWeaponry(Weaponry.Kinetic);
					return builder.BuildSpaceship();

				case SpaceshipType.Transport:
					builder.BuildFuselage(Fuselage.Framework);
					builder.BuildEngines(Engines.FTL);
					builder.BuildAvionics(Avionics.Proline);
					builder.BuildWeaponry(Weaponry.Beam);
					return builder.BuildSpaceship();
			}
			return null;
		}
	}
}
