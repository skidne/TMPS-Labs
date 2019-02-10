namespace Lab1
{
	public interface IStormtrooper
	{
		IStormtrooper Clone();
	}

	class Stormtrooper : IStormtrooper
	{
		public string Identifier { get; }
		public string Skill { get; }
		public string Spec { get; }
		public Spaceship Spaceship { get; }

		public Stormtrooper(string identifier, string skill, string spec, Spaceship spaceship)
		{
			Identifier = identifier;
			Skill = skill;
			Spec = spec;
			Spaceship = spaceship;
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
