namespace Lab1
{
	public interface IStormtrooper
	{
		Spaceship Spaceship { get; }
		IStormtrooper Clone();
	}

	class Stormtrooper : IStormtrooper
	{
		public string Identifier { get; }
		public string Skill { get; }
		public string Spec { get; }
		public Spaceship Spaceship { get; }

		public Stormtrooper(string id, string sk, string sp, Spaceship s)
		{
			Identifier = id;
			Skill = sk;
			Spec = sp;
			Spaceship = s;
		}

		public IStormtrooper Clone()
		{
			return MemberwiseClone() as IStormtrooper;
		}

		public override string ToString()
		{
			return $"{Identifier} of {Spaceship.Name} is a {Spec} and {Skill}";
		}
	}
}
