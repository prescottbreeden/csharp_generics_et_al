using System;

namespace generic_sll
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var bob = new SLL<int>();
      System.Console.WriteLine(bob.HasHead);
      // var node = new Node<int>(5);
      bob.AddToBack(5);
      bob.AddToBack(4);
      bob.AddToBack(3);
      bob.AddToBack(2);
      bob.AddToBack(1);
      bob.AddToFront(6);
      bob.AddToFront(7);
      bob.AddToFront(8);
      bob.PrintSLL();

      var chuck = new SLL<bool>();
      var trashpanda = new SLL<byte>();
      var nickfurry = new SLL<float>();
    }
  }
}
