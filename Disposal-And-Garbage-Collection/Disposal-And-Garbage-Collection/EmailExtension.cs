using System.Net.Mail;
using System.Net;

namespace Disposal_And_Garbage_Collection
{
	public static class EmailExtension
	{
		public static void SendEmail(string subject, string body, string reciverEmail)
		{
			string password = "tdjo oqqu fbbk vhpp";
			string emailSender = "travelbuddies.amdaris@gmail.com";

			using SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(emailSender, password);

			using MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(emailSender);
			mailMessage.To.Add(reciverEmail);
			mailMessage.Subject = subject;
			mailMessage.Body = body;

			smtpClient.Send(mailMessage);
		}
	}
}