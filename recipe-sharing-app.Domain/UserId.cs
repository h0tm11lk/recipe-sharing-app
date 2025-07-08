public class UserId
{
    public Guid Value { get; }

    public UserId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidUserIdException("ユーザIDは空であってはなりません。", nameof(value));
        }

        Value = value;
    }
    public override bool Equals(object? obj)
    {
        // 参照がnullか、型が異なる場合はfalse
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // キャストしてValueフィールドを比較
        UserId other = (UserId)obj;
        return Value.Equals(other.Value);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    // オブジェクトの文字列表現を返す
    public string ToString()
    {
        return $"UserId({Value})";
    }

    // 比較演算子のオーバーロード
    // 値オブジェクトは参照型
    // 値が同じときは等しいとみなしたい
    // そのための実装
    public static bool operator ==(UserId left, UserId right)
    {
        // nullチェックを行い、どちらかがnullの場合はfalse
        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
        {
            return false;
        }

        // Equalsメソッドを使用して比較
        return left.Equals(right);
    }

    public static bool operator !=(UserId? left, UserId? right)
    {
        return !(left == right);
    }
}