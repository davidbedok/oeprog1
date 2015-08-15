public class MenuColor
{

	public static readonly MenuColor DEFAULT_NORMAL = new MenuColor(ConsoleColor.Blue, ConsoleColor.White);
	public static readonly MenuColor DEFAULT_HIGHLIGHTED = new MenuColor(ConsoleColor.Yellow, ConsoleColor.DarkRed);

	private readonly ConsoleColor background;
	private readonly ConsoleColor foreground;

	public MenuColor(ConsoleColor background, ConsoleColor foreground)
	{
		this.background = background;
		this.foreground = foreground;
	}

	public void SetColors()
	{
		Console.BackgroundColor = this.background;
		Console.ForegroundColor = this.foreground;
	}

}