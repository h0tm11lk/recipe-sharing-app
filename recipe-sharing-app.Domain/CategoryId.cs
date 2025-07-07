public class CategoryId
{
    public Guid Value { get; private set; }

    public CategoryId(Guid value)
    {
        Value = value;
    }

    public bool Equals()
    {
        return Value.Equals(Value);
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