using System;

namespace InterfaceSample1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = {1,2,3};
           var newArr1 = Utility.Change(arr,new Square());
           var newArr2 = Utility.Change(arr,new AddFive());
           foreach(var i in newArr2)
           {
               Console.WriteLine(i);
           }
         Console.ReadKey();
        }
    }
}
