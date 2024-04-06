namespace Assignment_Behavioral_Design_Patterns.Requests
{
    using Assignment_Behavioral_Design_Patterns.Mediator;

    public record MessageRequest(string message) : IRequest;

    public class MessageRequestHandler : IRequestHandler<MessageRequest>
    {
        public void Handle(MessageRequest request)
        {
            Console.WriteLine($"Sending message: {request.message}");
        }
    }
}
