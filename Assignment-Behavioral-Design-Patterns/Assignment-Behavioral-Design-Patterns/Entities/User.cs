namespace Assignment_Behavioral_Design_Patterns.Entities
{
    using Assignment_Behavioral_Design_Patterns.AbstractsAndInterfaces;
    using Assignment_Behavioral_Design_Patterns.Enums;
    using Assignment_Behavioral_Design_Patterns.Mediator;
    using Assignment_Behavioral_Design_Patterns.Requests;

    public class User : ISubscriber<Order>
	{
		public required string Name { get; set; }

		public Role Role { get; set; }

		public bool IsSubscribed { get; set; }

		public void Notify(Order item)
		{
			Mediator mediator = new Mediator();
			mediator.RegisterHandler(typeof(MessageRequest), new MessageRequestHandler());
			string message = string.Empty;

			if (item.Status == Status.Created)
			{
				if (Role == Role.Client)
				{
					message = $"Successful created order from {Name}";
				}
				else if(Role == Role.Staff)
				{
					message = $"{Name} {Role} - new order is added to the store";
				}
			}
			else if (item.Status == Status.ReadyForShipping)
			{
				if (Role == Role.Client)
				{
					message = $"{Name} - Your order is waiting for shipping";
				}
				else if(Role == Role.Staff)
				{
					message = $"{Name} {Role} - The order is ready for shipping";
				}
			}

			mediator.Send(new MessageRequest(message));
		}
	}
}
