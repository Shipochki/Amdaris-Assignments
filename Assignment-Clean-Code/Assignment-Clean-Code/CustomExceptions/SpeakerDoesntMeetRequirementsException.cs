namespace Assignment_Clean_Code.CustomExceptions
{
	public class SpeakerDoesntMeetRequirementsException : Exception
	{
		public SpeakerDoesntMeetRequirementsException(string message)
			: base(message)
		{
		}

		public SpeakerDoesntMeetRequirementsException(string format, params object[] args)
			: base(string.Format(format, args)) { }
	}
}
