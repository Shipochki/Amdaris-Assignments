namespace Assignment_Structural_Design_Patterns
{
	public abstract class BaseTextDecoder : IText
	{
		protected IText _text;

        protected BaseTextDecoder(IText text)
        {
            _text = text;
        }

        public abstract string GetText();
	}
}
