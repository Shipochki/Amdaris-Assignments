namespace Assignment_Structural_Design_Patterns
{
	public class ColorText : BaseTextDecoder
	{
		private string _color;

        public ColorText(IText text, string color) : base(text) 
		{
			_color = color;
		}

        public override string GetText()
		{
			return $"{_text.GetText()} color: {_color},";
		}
	}
}
