namespace Assignment_Filesystem_And_Streams.Logger
{
	public class Logger : ILogger
	{
        public Logger()
        {
        }

        public void Log(string message)
		{
			using (StreamWriter sw = new StreamWriter($"Logs\\Logs_{DateTime.UtcNow}"))
			{
				sw.WriteLine(message);
			}
		}

		public void Read()
		{
			string? line = string.Empty;
			using(StringReader sr = new StringReader($"Logs\\Logs_{DateTime.UtcNow}"))
			{
				while((line = sr.ReadLine()) != null)
				{
                    Console.WriteLine(line);
                }
			}
		}
	}
}
