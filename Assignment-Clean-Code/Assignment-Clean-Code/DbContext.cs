using Assignment_Clean_Code.Entities;

namespace Assignment_Clean_Code
{
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
