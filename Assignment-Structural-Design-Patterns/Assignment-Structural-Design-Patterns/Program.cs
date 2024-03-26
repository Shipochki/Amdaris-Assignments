namespace Assignment_Structural_Design_Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IText text1 = new SimpleText();
			text1 = new BoldText(text1);
			text1 = new ItalicText(text1);

            Console.WriteLine(text1.GetText());
        }
	}
}
