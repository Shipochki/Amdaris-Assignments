namespace Assignment_Structural_Design_Patterns
{
	public class BoldText : BaseTextDecoder
	{
        public BoldText(IText text) : base(text) 
		{ 
		}

        public override string GetText()
		{
			return $"{_text.GetText()} bold,";
		}
	}
}
