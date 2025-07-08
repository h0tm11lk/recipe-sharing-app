public class InvalidUserIdException : Exception
{
    public string InvalidValue { get; }


    public InvalidUserIdException(string message, string invalidValue) : base(message)
    {
        this.InvalidValue = invalidValue;
    }

    public InvalidUserIdException(string message, string invalidValue, Exception innerException) : base(message, innerException)
    {
        InvalidValue = invalidValue;
    }
}