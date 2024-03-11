using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics
{
	public class Computer
	{
		private string? videoCard;

        private string cpu;

		private int ramSize;

		private int diskSize;

		private int flashDrive;

        public int FlashDrive 
		{
			get { return flashDrive; }
			set { 
				if (value <= 0) throw new ArgumentException("Flash drive it can't be zero or lower"); 
				this.flashDrive = value; 
			}
		}

        public Computer(string cpu, int ramSize, int diskSize)
        {
            this.cpu = cpu;
			this.ramSize = ramSize;
			this.diskSize = diskSize;
        }

		public void AddVideoCard(string videoCard)
		{
			this.videoCard = videoCard;
		}

		public string Info()
		{
			if (this.videoCard == null)
			{
				this.videoCard = "none";
			}

			return $"CPU: {this.cpu}, RAM size is {this.ramSize}, Disk size is {this.diskSize}, VideoCard: {this.videoCard}, FlashDrive: {this.flashDrive}";
		}
	}
}
