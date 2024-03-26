namespace Assignment_Structural_Design_Patterns
{
	public class SimpleText : IText
	{
		private string _text;
        public SimpleText(string text)
        {
            _text = text;
        }

        public string GetText()
		{
			return $"This is \"{_text}\" with:";
		}
	}
}
