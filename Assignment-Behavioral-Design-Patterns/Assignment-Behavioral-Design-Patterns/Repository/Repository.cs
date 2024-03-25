namespace Assignment_Behavioral_Design_Patterns.Repository
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using System.Collections.Generic;

	public class Repository<T> : IRepository<T> where T : Entity
	{
		private readonly DbContext<T> _context;

		public Repository(DbContext<T> context)
		{
			_context = context;
		}

		public T? Add(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException($"Invalid {entity.GetType().Name}");
			}

			int newId = new Random().Next(1, 10000000);
			entity.Id = newId;

			this._context.Entities.Add(entity);
			return entity;
		}

		public List<T> GetAll()
		{
			return _context.Entities;
		}

		public T? GetEntityById(int id)
		{
			return _context.Entities.SingleOrDefault(e => e.Id == id);
		}
	}
}
