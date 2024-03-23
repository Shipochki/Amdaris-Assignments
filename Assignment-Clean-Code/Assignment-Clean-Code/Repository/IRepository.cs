namespace Assignment_Clean_Code.Repository
{
    using Assignment_Clean_Code.Entities;

    public interface IRepository<T> where T : Entity
    {
        int SaveSpeaker(T speaker);
    }
}
