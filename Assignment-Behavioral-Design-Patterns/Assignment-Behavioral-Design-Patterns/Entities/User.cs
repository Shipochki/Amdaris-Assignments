namespace Assignment_Behavioral_Design_Patterns.Entities
{
	using Assignment_Behavioral_Design_Patterns.Enums;
	using Assignment_Behavioral_Design_Patterns.Mediator;

	public class User : ISubscriber<Order>
	{
        public required string Name { get; set; }

		public Role Role { get; set; }

		public void Notify(Order item)
		{
			Mediator mediator = new Mediator();
			mediator.RegisterHandler(typeof(MessageRequest), new MessageRequestHandler());

			if(Role == Role.Client)
			{
				//Mediator send to client
			}
			else
			{
				//Mediator send to staff
			}
		}
	}
}
