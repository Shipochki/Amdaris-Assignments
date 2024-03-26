namespace Assignment_Structural_Design_Patterns
{
	public class UnderlineText : BaseTextDecoder
	{
        public UnderlineText(IText text) : base(text) 
		{ 
		}

        public override string GetText()
		{
			return $"{_text.GetText()} underline,";
		}
	}
}
