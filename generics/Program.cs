using System;

namespace generics
{
  class Program
  {
    static void Main(string[] args)
    {
    //   Console.WriteLine("Hello World!");
    //   var book = new Book { Isbn = "1111", Title = "C# Advanced " };

    //   var numbers = new List();
    //   numbers.Add(10);

    //   var books = new BookList();
    //   books.Add(book);

    //   var numbers2 = new GenericList<int>();
    //   numbers.Add(10);

    //   var books2 = new GenericList<Book>();
    //   books2.Add(new Book());

    //   var dictionary = new GenericDictionary<string, Book>();
    //   dictionary.Add("1234", new Book());

      var number = new Nullable<int>(5);
      System.Console.WriteLine("Has Value ?" + number.HasValue);
      System.Console.WriteLine("Value: " + number.GetValueOrDefault());

      var n = new Nullable<int>();
      System.Console.WriteLine("Has Value ?" + n.HasValue);
      System.Console.WriteLine("Value: " + n.GetValueOrDefault());
    }
  }
}
