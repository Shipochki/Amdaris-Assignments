namespace Assignment_Behavioral_Design_Patterns.Repository
{
    using Assignment_Behavioral_Design_Patterns.Entities;

    public interface IRepository<T> where T : Entity
    {
        T? GetEntityById(int id);

        T? Add(T entity);

        List<T> GetAll();
    }
}
