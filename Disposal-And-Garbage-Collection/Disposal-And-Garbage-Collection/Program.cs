namespace Disposal_And_Garbage_Collection
{
	using static EmailExtension;
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Email:");
            string? reciverEmail = Console.ReadLine();

			try
			{
				SendEmail(subject: "Subscribing to the newsletter", body: "Thank you! For subscribing to our newsletter!", reciverEmail);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
