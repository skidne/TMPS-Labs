namespace Lab1
{
	public enum Fuselage
	{
		Framework, Monocoque, SemiMonocoque
	}

	public enum Engines
	{
		FTL, Photonic, Quantum
	}

	public enum Avionics
	{
		Rockwell, Proline, Bendix
	}

	public enum Weaponry
	{
		Beam, Kinetic, Missile
	}

	public class Spaceship
	{
		public string Name { get; }
		public Fuselage Fuselage { get; set; }
		public Engines Engines { get; set; }
		public Avionics Avionics { get; set; }
		public Weaponry Weaponry { get; set; }

		public Spaceship(string name) => Name = name;

		public override string ToString()
		{
			return $"{Name} has {Fuselage} fuselage, {Engines} engines, " +
				$"{Avionics} avionics and {Weaponry} weaponry.";
		}
	}

	public interface ISpaceshipBuilder
	{
		Spaceship Spaceship { get; }

		void BuildFuselage();
		void BuildEngines();
		void BuildAvionics();
		void BuildWeaponry();
	}

	public class CombatSpaceshipBuilder : ISpaceshipBuilder
	{
		public Spaceship Spaceship { get; }

		public CombatSpaceshipBuilder(string name) =>
			Spaceship = new Spaceship(name);

		public void BuildFuselage() =>
			Spaceship.Fuselage = Fuselage.SemiMonocoque;
		public void BuildEngines() =>
			Spaceship.Engines = Engines.Photonic;
		public void BuildAvionics() =>
			Spaceship.Avionics = Avionics.Rockwell;
		public void BuildWeaponry() =>
			Spaceship.Weaponry = Weaponry.Missile;
	}

	public class DefenseSpaceshipBuilder : ISpaceshipBuilder
	{
		public Spaceship Spaceship { get; }

		public DefenseSpaceshipBuilder(string name) =>
			Spaceship = new Spaceship(name);

		public void BuildFuselage() =>
			Spaceship.Fuselage = Fuselage.Monocoque;
		public void BuildEngines() =>
			Spaceship.Engines = Engines.Quantum;
		public void BuildAvionics() =>
			Spaceship.Avionics = Avionics.Bendix;
		public void BuildWeaponry() =>
			Spaceship.Weaponry = Weaponry.Kinetic;
	}

	public class TransportSpaceshipBuilder : ISpaceshipBuilder
	{
		public Spaceship Spaceship { get; }

		public TransportSpaceshipBuilder(string name) =>
			Spaceship = new Spaceship(name);

		public void BuildFuselage() =>
			Spaceship.Fuselage = Fuselage.Framework;
		public void BuildEngines() =>
			Spaceship.Engines = Engines.FTL;
		public void BuildAvionics() =>
			Spaceship.Avionics = Avionics.Proline;
		public void BuildWeaponry() =>
			Spaceship.Weaponry = Weaponry.Beam;
	}

	public class SpaceshipManufacturer
	{
		public void Build(ISpaceshipBuilder builder)
		{
			builder.BuildFuselage();
			builder.BuildEngines();
			builder.BuildAvionics();
			builder.BuildWeaponry();
		}
	}
}