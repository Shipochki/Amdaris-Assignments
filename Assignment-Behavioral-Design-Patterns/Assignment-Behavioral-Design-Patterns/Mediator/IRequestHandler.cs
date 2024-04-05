
namespace Assignment_Behavioral_Design_Patterns.Mediator
{
	public interface IRequestHandler<in T> where T : IRequest
	{
		void Handle(T request);
	}
}
