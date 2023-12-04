using Generics;

namespace Prog
{
    class Prog
    {
        void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(2);

            Generics.Generics.Sort<int>(list);
        }
    }
}