public class Quantity
{
    public int Value { get; private set; }
    public string Unit { get; private set; }

    public Quantity Add()
    {
        // Logic to add quantities
        return new Quantity { Value = this.Value + Value, Unit = this.Unit };
    }

    public bool Equals()
    {
        return Value.Equals(Value) && Unit.Equals(Unit);
    }

    public int GetHashCode()
    {
        return Value.GetHashCode() ^ Unit.GetHashCode();
    }

    public string ToString()
    {
        return $"{Value} {Unit}";
    }
}