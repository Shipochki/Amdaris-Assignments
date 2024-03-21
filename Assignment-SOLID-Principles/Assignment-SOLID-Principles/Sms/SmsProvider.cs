namespace Assignment_SOLID_Principles.Sms
{
	public class SmsProvider
	{
		private ISmsSender _sender;

        public SmsProvider(ISmsSender sender)
        {
            _sender = sender;
        }

        public void Send(string receiverNumber, string message)
        {
            _sender.SmsSend(receiverNumber, message);
        }
    }
}
