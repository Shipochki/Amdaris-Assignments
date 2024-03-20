namespace Assignment_Filesystem_And_Streams
{
	public static class FileSystemInformation
	{
		public static void GetInformationAboutFileSystem()
		{
			DirectoryInfo di = new DirectoryInfo(@"D:\");
			FileSystemInfo[] dirs = di.GetDirectories("*p*");
            Console.WriteLine($"Number of directories with a p:{dirs.Length}");

            foreach (DirectoryInfo diNext in dirs)
            {
                Console.WriteLine($"The number of files and directories in {diNext} with an e is {diNext.GetFileSystemInfos("*e*").Length}");
            }
        }
	}
}
