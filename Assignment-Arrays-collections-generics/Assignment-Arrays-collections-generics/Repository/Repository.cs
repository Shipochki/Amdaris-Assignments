namespace Assignment_Arrays_collections_generics.Repository
{
	using Assignment_Arrays_collections_generics.Entities;

	public class Repository<T> : IRepository<T> where T : Entity
	{
		private readonly List<T> _entities;

		public Repository()
		{
			_entities = new List<T>();
		}

		public void Add(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException($"Method: Add, invalid entity!");
			}

			_entities.Add(entity);
		}

		public void Delete(int id)
		{
			T? result = _entities.FirstOrDefault(e => e.Id == id);

			if (result == null)
			{
				throw new ArgumentNullException($"Method: Delete, invalid Id {id} class: {typeof(T).Name}!");
			}

			_entities.Remove(result);
		}

		public IEnumerable<T> GetAll()
		{
			return _entities;
		}

		public T GetById(int id)
		{
			T? result = _entities.FirstOrDefault(e => e.Id == id);

			if (result == null)
			{
				throw new ArgumentNullException($"Method: GetById, invalid Id {id} class: {typeof(T).Name}!");
			}

			return result;
		}

		public void Update(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException($"Method: Update, invalid entity!");
			}

			T? result = _entities.FirstOrDefault(e => e.Id == entity.Id);

			result = entity;
		}
	}
}
