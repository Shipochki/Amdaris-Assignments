namespace Assignment_Structural_Design_Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> commands = new List<string>();
			string color = string.Empty;
            Console.WriteLine("Write text:");
            string input = Console.ReadLine() ?? string.Empty;
			IText text = new SimpleText(input);

			while (true)
			{
				Console.WriteLine("Add formatting:");
				Console.WriteLine("- Underline");
				Console.WriteLine("- Italic");
				Console.WriteLine("- Color");
                Console.WriteLine("- Bold");
                Console.WriteLine("- Done");

                string command = Console.ReadLine() ?? string.Empty;
				command = command.ToLower();

				if (command == "done") break;
				else if(command == "color")
				{
                    Console.WriteLine("Write color");
					color = Console.ReadLine() ?? string.Empty;
                }
				commands.Add(command);
                Console.WriteLine($"Successful added {command}");
                Console.WriteLine();
            }

			foreach (var command in commands)
			{
				if (command == "underline")
				{
					text = new UnderlineText(text);
				}
				else if (command == "italic")
				{
					text = new ItalicText(text);
				}
				else if (command == "color")
				{
					text = new ColorText(text, color);
				}
				else if (command == "bold")
				{
					text = new BoldText(text);
				}
            }

            Console.WriteLine(text.GetText());
        }
	}
}
