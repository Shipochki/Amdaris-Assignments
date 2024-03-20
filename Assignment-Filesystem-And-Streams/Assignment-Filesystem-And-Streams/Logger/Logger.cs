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

		public async void Read()
		{
			string pathExtension = $"\\Logs_{DateTime.UtcNow.ToString("dd-MM-yyyy")}";
			if (File.Exists(path + pathExtension))
			{
                await Console.Out.WriteLineAsync(await File.ReadAllTextAsync(path + pathExtension));
            }
		}
	}
}
