namespace Assignment_Behavioral_Design_Patterns.AbstractsAndInterfaces
{
    public abstract class AbstractPublisher<T>
    {
        private List<ISubscriber<T>> subscribers;
        public AbstractPublisher()
        {
            subscribers = new List<ISubscriber<T>>();
        }
        public void AddSubscriber(ISubscriber<T> subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void RemoveSubscriber(ISubscriber<T> subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void Publish(T item)
        {
            subscribers.ForEach(s => s.Notify(item));
        }
        public bool IsSubscribed(ISubscriber<T> sub)
        {
            if(sub == null) return false;

            return subscribers.Contains(sub);
        }
    }
}
