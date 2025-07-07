public class TagId
{
    public Guid Value { get; private set; }

    public void Equlas()
    {
        // Logic to compare TagId instances
    }

    public int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public string ToString()
    {
        return Value.ToString();
    }
}