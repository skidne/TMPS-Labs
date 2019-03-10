namespace Labs
{
	public sealed class CommandCenter
	{
		private CommandCenter() { }

		public static CommandCenter Instance { get; } = new CommandCenter();
		public IFleet Fleet { get; } = new Fleet();
	}
}
