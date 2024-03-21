
namespace Assignment_SOLID_Principles.Sms
{
	public interface ISmsSender
	{
		void SmsSend(string number, string receiver);
	}
}
