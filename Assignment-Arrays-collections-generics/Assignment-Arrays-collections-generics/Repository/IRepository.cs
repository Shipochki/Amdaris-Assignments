namespace Assignment_Arrays_collections_generics.Repository
{
	using Assignment_Arrays_collections_generics.Entities;

	public interface IRepository<T> where T : Entity
	{
		T GetById(int id);
		IEnumerable<T> GetAll();

		void Add(T entity);

		void Update(T entity);

		void Delete(int id);
	}
}
