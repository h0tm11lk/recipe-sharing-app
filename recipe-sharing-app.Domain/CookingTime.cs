public class CookingTime
{
    public int Minutes { get; private set; }

    public CookingTime Add()
    {
        return new CookingTime { Minutes = this.Minutes + 1 };
    }

    public bool Equals()
    {
        return Minutes.Equals(Minutes);
    }

    public int GetHashCode()
    {
        return Minutes.GetHashCode();
    }

    public string ToString()
    {
        return $"{Minutes} minutes";
    }
}