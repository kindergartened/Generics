using Generics;

namespace Prog
{
    class Prog
    {
        static void Main()
        {
            List<char> list  = new List<char>();
            list.Add('a');
            list.Add('w');
            list.Add('c');
            list.Add('d');

            UniversalSortings.QuickSort(list);
            Console.WriteLine(String.Join(" ",list));

        }
    }
}