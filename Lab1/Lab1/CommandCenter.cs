namespace Lab1
{
	class CommandCenter
	{
		private CommandCenter() { }

		public static IFleet Fleet { get; } = new Fleet();
	}
}
