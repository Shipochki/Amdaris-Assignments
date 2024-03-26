namespace Assignment_Structural_Design_Patterns
{
	public class ColorText : BaseTextDecoder
	{
        public ColorText(IText text) : base(text) 
		{ 
		}

        public override string GetText()
		{
			return $"{_text.GetText()} with color";
		}
	}
}
