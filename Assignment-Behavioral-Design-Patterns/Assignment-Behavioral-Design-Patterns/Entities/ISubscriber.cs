namespace Assignment_Behavioral_Design_Patterns.Entities
{
	public interface ISubscriber<T>
	{
		void Notify(T item);
	}
}
