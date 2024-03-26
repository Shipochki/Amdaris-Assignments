﻿namespace Assignment_Structural_Design_Patterns
{
	public class Engine
	{
		public void Run()
		{
			List<string> commands = new List<string>();
			string color = string.Empty;
			Console.WriteLine("Write text:");
			string textInput = Console.ReadLine() ?? string.Empty;
			IText text = new SimpleText(textInput);

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
				else if (command == "color")
				{
					Console.WriteLine("Write color:");
					color = Console.ReadLine() ?? string.Empty;
				}
				commands.Add(command);
				Console.WriteLine($"Successful added {command}");
				Console.WriteLine();
			}

			Console.WriteLine("Do you want to see added formating to the text: (y/n)");
			string input = Console.ReadLine() ?? string.Empty;
			if (input == "y")
			{
				while (true)
				{
					Console.WriteLine($"Formatts: {string.Join(", ", commands)}");

					Console.WriteLine("Do you want to delete format? (y/n)");
					string command = Console.ReadLine() ?? string.Empty;
					if (command == "y")
					{
						Console.WriteLine();
						while (true)
						{
							Console.WriteLine("Write format for deleting");
							command = Console.ReadLine() ?? string.Empty;
							if (commands.Contains(command))
							{
								commands.Remove(command);
							}

							Console.WriteLine("Done with deleting? (y/n)");
							command = Console.ReadLine() ?? string.Empty;
							if (command == "y")
							{
								break;
							}
						}
					}

					Console.WriteLine("Done with formats? (y/n)");
					input = Console.ReadLine() ?? string.Empty;
					if (input == "y")
					{
						break;
					}
				}
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
