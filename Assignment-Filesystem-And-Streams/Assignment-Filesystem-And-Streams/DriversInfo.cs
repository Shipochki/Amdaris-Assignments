namespace Assignment_Filesystem_And_Streams
{
	public static class DriversInfo
	{
		public static void GetInformationAboutDrivers()
		{
			DriveInfo[] myDrivers = DriveInfo.GetDrives();

            foreach (var drive in myDrivers)
            {
                Console.WriteLine($"Name: {drive.Name}");
				Console.WriteLine($"Type: {drive.DriveType}");
				if(drive.IsReady)
				{
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace / 1000000000} GB");
					Console.WriteLine($"Format: {drive.DriveFormat}");
					Console.WriteLine($"Label: {drive.VolumeLabel}\n");
                }
            }
        }
	}
}
