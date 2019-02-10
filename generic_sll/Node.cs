namespace generic_sll
{
  public class Node<T> where T : struct
  {
    private object _value;
    public Node<T> next { get; set; }
    public bool HasValue
    {
      get { return _value != null; }
    }

    public T GetValueOrDefault()
    {
      if (HasValue)
        return (T)_value;

      return default(T);
    }

    public Node(T value)
    {
      _value = value;
    }
  }
}
