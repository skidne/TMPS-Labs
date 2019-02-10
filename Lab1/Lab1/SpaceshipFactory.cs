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
			ISpaceshipBuilder sb = new SpaceshipBuilder(name);

			switch (type)
			{
				case SpaceshipType.Combat:
					sb.BuildFuselage(Fuselage.SemiMonocoque);
					sb.BuildEngines(Engines.Photonic);
					sb.BuildAvionics(Avionics.Rockwell);
					sb.BuildWeaponry(Weaponry.Missile);
					return sb.BuildSpaceship();

				case SpaceshipType.Defense:
					sb.BuildFuselage(Fuselage.Monocoque);
					sb.BuildEngines(Engines.Quantum);
					sb.BuildAvionics(Avionics.Bendix);
					sb.BuildWeaponry(Weaponry.Kinetic);
					return sb.BuildSpaceship();

				case SpaceshipType.Transport:
					sb.BuildFuselage(Fuselage.Framework);
					sb.BuildEngines(Engines.FTL);
					sb.BuildAvionics(Avionics.Proline);
					sb.BuildWeaponry(Weaponry.Beam);
					return sb.BuildSpaceship();
			}
			return null;
		}
	}
}
