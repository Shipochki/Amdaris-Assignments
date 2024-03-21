namespace Assignment_SOLID_Principles.Sms
{
	public class SmsSender : ISmsSender
	{
		private string _senderNumber;

        public SmsSender(string senderNumber)
        {
            _senderNumber = senderNumber;
        }

        public void SmsSend(string receiverNumber, string message)
		{
            Console.WriteLine($"{_senderNumber} send sms message \"{message}\" to {receiverNumber}");
        }
    }
}
