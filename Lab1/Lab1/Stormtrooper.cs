namespace Lab1
{
	public interface IStormtrooper
	{
		string Identifier { get; }
		Spaceship Spaceship { get; }
		IStormtrooper Clone();
	}

	abstract class Stormtrooper : IStormtrooper
	{
		public string Identifier { get; }
		public Spaceship Spaceship { get; }

		public Stormtrooper(string id, Spaceship s)
		{
			Identifier = id;
			Spaceship = s;
		}

		public IStormtrooper Clone()
		{
			return MemberwiseClone() as IStormtrooper;
		}

		public abstract override string ToString();
	}

	class Sandtrooper : Stormtrooper
	{
		public Sandtrooper(string id, Spaceship s) : base(id, s) { }

		public override string ToString()
		{
			return $"{Identifier} of {Spaceship.Name} is a Sandtrooper " +
				$"usually found on Tatooine.";
		}
	}

	class Deathtrooper : Stormtrooper
	{
		public Deathtrooper(string id, Spaceship s) : base(id, s) { }

		public override string ToString()
		{
			return $"{Identifier} of {Spaceship.Name} is a Deathtrooper. " +
				$"Very dangerous. Much Ouch. If they don't miss, ofc. " +
				$"Which is. Always. Hmmm.";
		}
	}

	class Scouttrooper : Stormtrooper
	{
		public Scouttrooper(string id, Spaceship s) : base(id, s) { }

		public override string ToString()
		{
			return $"{Identifier} of {Spaceship.Name} is a Scouttrooper with " +
				$"recon and survival skills.";
		}
	}
}
