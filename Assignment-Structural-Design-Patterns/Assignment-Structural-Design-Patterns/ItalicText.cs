namespace Assignment_Structural_Design_Patterns
{
	public class ItalicText : BaseTextDecoder
	{
        public ItalicText(IText text) : base(text) 
		{ 
		}

        public override string GetText()
		{
			return $"{_text.GetText()} with italic";
		}
	}
}
