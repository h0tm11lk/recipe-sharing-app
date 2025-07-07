public class CategoryId
{
    public Guid Value { get; private set; }

    public CategoryId(Guid value)
    {
        Value = value;
    }
}