using Assignment_Clean_Code.Entities;
using Assignment_Clean_Code.Repository;
using Assignment_Clean_Code.SpeakerExtensions;

namespace Assignment_Clean_Code
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Data data = new Data();
			DbContext<Speaker> dbContext = new DbContext<Speaker>();
			IRepository<Speaker> repository = new Repository<Speaker>(dbContext);
			Speaker speaker = new Speaker()
			{
				FirstName = "Stefan",
				LastName = "Petrov",
				Email = "stefcho@gmail.com",
				HasBlog = true,
				BlogURL = "www.blogUrl.com",
				Browser = new WebBrowser("InternetExplorer", 2),
				Certifications = new List<string>(),
				Employer = "Ivan",
				RegistrationFee = 3,
				Sessions = new List<Session> { new Session("OnSees", "CoolSes")}
			};
			speaker.Register(repository, data);

			Speaker? result = repository.GetEntityById(speaker.Id);

			if(result == null)
			{
                Console.WriteLine("Invalid speaker");
            }

            Console.WriteLine($"Successful created: {result.FirstName} {result.LastName}");
        }
	}
}
