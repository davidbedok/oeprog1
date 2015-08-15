public class SimpleMenu
{
	private static readonly int MAXIMUM_MENU_ITEMS = 10;

	private readonly MenuTemplate template;
	private readonly Position position;
	private readonly MenuItem[] items;
	private int index;
	private int current;

	public SimpleMenu(int top, int left)
		: this(top, left, MenuTemplate.DEFAULT_TEMPLATE)
	{
	}

	public SimpleMenu(int top, int left, MenuTemplate template)
		: this(top, left, template, MAXIMUM_MENU_ITEMS)
	{

	}

	public SimpleMenu(int top, int left, MenuTemplate template, int maxMenuItem)
	{
		this.position = new Position(top, left);
		this.template = template;
		this.items = new MenuItem[maxMenuItem];
		this.index = 0;
		this.current = 0;
	}

	public void Add(int id, String label)
	{
		if (this.index < this.items.Length)
		{
			this.items[this.index++] = new MenuItem(id, label);
		}
	}

}