namespace Assignment_Behavioral_Design_Patterns.Mediator
{
	public class Mediator
	{
		private Dictionary<Type, object> dictionary;

		public Mediator()
		{
			this.dictionary = new();
		}

		public void RegisterHandler<T>(Type type, IRequestHandler<T> handler) where T : IRequest
		{
			dictionary[type] = handler;
		}

		public void UnregisterHandler(Type type)
		{
			dictionary.Remove(type);
		}

		public void Send<T>(T request) where T : IRequest
		{
			var handler = dictionary[request.GetType()] as IRequestHandler<T>;

			if(handler == null)
			{
				return;
			}

			handler.Handle(request);
		}
	}
}
