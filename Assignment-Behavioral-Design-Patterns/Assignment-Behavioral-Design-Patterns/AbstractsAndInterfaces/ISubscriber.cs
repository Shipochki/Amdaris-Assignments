namespace Assignment_Behavioral_Design_Patterns.AbstractsAndInterfaces
{
    public interface ISubscriber<T>
    {
        void Notify(T item);
    }
}
