namespace Generics
{
    public static class UniversalSortings
    {
        /// <summary>
        /// Пузырьковая сортировка
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static void BubbleSort<T>(this List<T> list) where T : IComparable<T>
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Универсальная быстрая сортировка (Сортировка Хоара)
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static void QuickSort<T>(this List<T> list) where T : IComparable<T>
        {
            int left = 0;
            int right = list.Count - 1;
            SortArray(list, left, right); 
        }
        /// <summary>
        /// вспомогательный метод для QuickSort
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список</param>
        /// <param name="left">левая граница</param>
        /// <param name="right">правая граница</param>
        public static void SortArray<T>(this List<T> list, int left, int right) where T : IComparable<T>
        {
            int i = left;
            int j = right;
            T mid = list[(left + right) / 2];
            while (i < j)
            {
                while (list[i].CompareTo(mid) < 0)
                    i++;
                while (list[j].CompareTo(mid) > 0)
                    j--;
                if (i <= j)
                {
                    (list[i], list[j]) = (list[j], list[i]);
                    i++;
                    j--;
                }
            }
            if (left < j)
                SortArray(list, left, j);
            if (i < right)
                SortArray(list, i, right);
        }
    }
}