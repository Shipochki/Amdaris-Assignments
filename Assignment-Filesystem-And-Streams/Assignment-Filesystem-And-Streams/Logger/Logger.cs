namespace Assignment_Filesystem_And_Streams.Logger
{
	public class Logger : ILogger
	{
		private string path = @"D:\Amdaris-Assignments\Amdaris-Assignments\Assignment-Filesystem-And-Streams\Assignment-Filesystem-And-Streams\Logs";
		public Logger()
		{
		}

		public async void Log(string message)
		{
			string pathExtension = $"\\Logs_{DateTime.UtcNow.ToString("dd-MM-yyyy")}";
			await File.AppendAllTextAsync(path + pathExtension, message + Environment.NewLine);
		}

		public void Read()
		{
			string pathExtension = $"\\Logs_{DateTime.UtcNow.ToString("dd-MM-yyyy")}";
			if (File.Exists(path + pathExtension))
			{
				using (StreamReader sr = File.OpenText(path + pathExtension))
				{
					string? line = string.Empty;
					while ((line = sr.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
				}
			}
		}
	}
}
