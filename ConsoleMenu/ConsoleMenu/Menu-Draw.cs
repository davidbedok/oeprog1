private void Draw()
{
	this.template.Normal.SetColors();
	int maxLength = this.GetTheLargestLength() + 2;

	this.DrawTop(maxLength);
	int row = 0;
	for (int i = 0; i < this.index; i++)
	{
		this.DrawMenuItem(maxLength, i, ++row);
		if (i != this.index - 1)
		{
			this.DrawMiddle(maxLength, ++row);
		}
	}
	this.DrawBottom(maxLength, ++row);
}

private int GetTheLargestLength()
{
	int ret = 0;
	if (this.index > 0)
	{
		ret = this.items[0].Length;
		for (int i = 1; i < this.index; i++)
		{
			int current = this.items[i].Length;
			if (ret < current)
			{
				ret = current;
			}
		}
	}
	return ret;
}

private void DrawTop(int maxLength)
{
	this.position.SetCursor(0);
	Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
}

private void DrawMenuItem(int maxLength, int index, int row)
{
	this.position.SetCursor(row);
	this.template.Normal.SetColors();
	Console.Write("|");
	this.SetColors(index);
	Console.Write(" " + this.items[index].Label.PadRight(maxLength - 1, ' '));
	this.template.Normal.SetColors();
	Console.Write("|");
}

private void SetColors(int index)
{
	(index == this.current ? this.template.Highlighted : this.template.Normal).SetColors();
}

private void DrawMiddle(int maxLength, int row)
{
	this.position.SetCursor(row);
	Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
}

private void DrawBottom(int maxLength, int row)
{
	this.position.SetCursor(row);
	Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
}