using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericListWithObject intList = new GenericListWithObject();

            intList.Add(500);
            intList.Add(600);

            Console.WriteLine(intList.GetAt(0));
            Console.WriteLine(intList.GetAt(1));

            GenericListWithObject stringList = new GenericListWithObject();

            stringList.Add("pitch");
            stringList.Add("shifter");

            Console.WriteLine(stringList.GetAt(0));
            Console.WriteLine(stringList.GetAt(1));

        }
    }
}
