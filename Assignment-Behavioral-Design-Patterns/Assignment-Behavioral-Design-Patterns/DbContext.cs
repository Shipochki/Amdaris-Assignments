namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public class DbContext<T> where T : Entity
	{
		private List<T> _entities;

		public DbContext()
		{
			_entities = new List<T>();
		}

		public List<T> Entities => this._entities;
	}
}
