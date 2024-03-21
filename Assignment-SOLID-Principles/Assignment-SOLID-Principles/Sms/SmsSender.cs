
namespace Assignment_SOLID_Principles.Sms
{
	public class SmsSender : ISmsSender
	{
		private const string senderNumber = "0895437234";

		public void SmsSend(string receiverNumber, string message)
		{
            Console.WriteLine($"{senderNumber} send sms messge {message} to {receiverNumber}");
        }
	}
}
