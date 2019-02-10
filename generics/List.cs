using System;

namespace generics
{
  public class GenericList<T>
  {
    public void Add(T value)
    {

    }

    public T this[int index]
    {
      get { throw new NotImplementedException(); }
    }
  }
  public class ObjectList
  {
    public void Add(object value)
    {

    }

    public object this[int index]
    {
      get { throw new NotImplementedException(); }
    }
  }
  public class List
  {
    public int this[int index]
    {
      get { throw new NotImplementedException(); }
    }

    public void Add(int number)
    {
      throw new NotImplementedException();
    }

  }
}
