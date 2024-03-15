
namespace Assignment_Debugging_And_Exception_Handling.CustomExceptions
{
	public class CarCollectionException : Exception
	{
        public CarCollectionException()
        {   
        }

        public CarCollectionException(string message) : base(message)
        {
        }

        public CarCollectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
