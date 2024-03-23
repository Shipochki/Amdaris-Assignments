namespace Assignment_Clean_Code.CustomExceptions
{
	public class NoSessionsApprovedException : Exception
	{
		public NoSessionsApprovedException(string message)
			: base(message)
		{
		}
	}
}
