namespace generic_sll
{

  public class SLL<T> where T : struct
  {
    private Node<T> _head;
    public bool HasHead 
    { 
      get { return _head != null; }
    }

    public SLL() { }

    public void PrintSLL()
    {
      if(HasHead)
      {
        var runner = _head;
        while(runner != null)
        {
          System.Console.WriteLine(runner.GetValueOrDefault());
          runner = runner.next;
        }
      }
    }

    public void AddToBack(T value)
    {
      Node<T> newNode = new Node<T>(value);
      if (HasHead)
      {
        var runner = _head; 
        while(runner.next != null)
          runner = runner.next;
        runner.next = newNode; 
      }
      else
      {
        _head = newNode;
      }
    }

    public void AddToFront(T value)
    {
      Node<T> newNode = new Node<T>(value);
      if (HasHead)
      {
        var temp = _head;
        _head = newNode;
        _head.next = temp;
      }
      else
      {
        _head = newNode;
      }
    }
  }
}
