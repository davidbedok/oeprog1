public MenuItem Process()
{
	ConsoleKey key;
	do
	{
		this.Draw();
		key = Console.ReadKey(true).Key;
		switch (key)
		{
			case ConsoleKey.UpArrow:
				this.Up();
				break;
			case ConsoleKey.DownArrow:
				this.Down();
				break;
		}
	} while (key != ConsoleKey.Enter);
	return this.items[this.current];
}

private void Down()
{
	this.current = this.current < this.index - 1 ? this.current + 1 : 0;
}

private void Up()
{
	this.current = this.current > 0 ? this.current - 1 : this.index - 1;
}