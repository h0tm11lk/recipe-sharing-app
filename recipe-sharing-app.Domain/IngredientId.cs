public class IngredientId
{
    public Guid Value { get; private set; }

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