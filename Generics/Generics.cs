namespace Generics
{
    public static class UniversalSortings
    {



        /// <summary>
        /// шаблон нашего компаратора
        /// </summary>
        /// <typeparam name="T"> тип нашего списка </typeparam>
        /// <param name="a"> первый элемент для сравнения </param>
        /// <param name="b"> второй элемент для сравнение </param>
        /// <returns> 
        /// если a = b возращает 0
        /// если a > b возращает 1
        /// если a < b возращает -1
        /// </returns>
        public delegate int Comp<T>(T a, T b);



        /// <summary>
        /// Быстрая сортировка, со своим условием
        /// </summary>
        /// <typeparam name="T"> тип данных нашего списка </typeparam>
        /// <param name="mas"> список которой, будем сортировать </param>
        /// <param name="func"> функция с помощью которой мы будем сравнивать элементы списка типа Comp<T> </param>
        public static void QuickSort<T>(List<T> mas, Comp<T> func){
            if(mas.Count == 0){
                return;
            }
            quickRec(mas, 0, mas.Count - 1, func);
        }




        /// <summary>
        /// рекурсивная функция быстрой сортировки
        /// </summary>
        /// <typeparam name="T"> тип элемента данного списка </typeparam>
        /// <param name="mas">  список которой, будем сортировать </param>
        /// <param name="start"> с какого элемента начинаем алгоритм </param>
        /// <param name="end"> до какого элемента начинаем алгоритм </param>
        /// <param name="func"> функция с помощью которой мы будем сравнивать элементы списка </param>
        private static void quickRec<T>(List<T> mas, int start, int end, Comp<T> func){
            if(start < end){
                int mid = partition(mas, start, end, func);
                quickRec( mas, start, mid-1, func);
                quickRec(mas, mid+1, end, func);
            }
        }




        /// <summary>
        /// вспомогательная функция разделение
        /// </summary>
        /// <typeparam name="T"> тип элемента данного списка </typeparam>
        /// <param name="mas"> массив которой, будем сортировать </param>
        /// <param name="start"> с какого элемента начинаем алгоритм </param>
        /// <param name="end"> до какого элемента начинаем алгоритм </param>
        /// <param name="func"> функция с помощью которой мы будем сравнивать элементы списка </param>
        /// <returns> возращает местополежение опорного элемента после выполнение алгоритма </returns>
        private static int partition<T>(List<T> mas , int start, int end, Comp<T> func){
            T mid = mas[start];
            int i = start+1;
            int j = end;
            while(i <= j){
                while(i <= end && func(mas[i], mid) < 0){
                    i++;
                }
                while(j > start && func(mas[j], mid) > 0){
                    j--;
                }
                if(i >= j){
                    break;
                }
                T x = mas[i];
                mas[i] = mas[j];
                mas[j] = x;
                i++;
                j--;
            }
            T X = mas[start];
            mas[start] = mas[j];
            mas[j] = X;
            return j;
        }


        /// <summary>
        /// Пузырьковая сортировка
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static List<T> BubbleSort<T>(this List<T> list) where T : IComparable<T>
        {
            List<T> result = new(list);
            int n = result.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (result[j].CompareTo(result[j + 1]) > 0)
                    {
                        T temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Универсальная быстрая сортировка (Сортировка Хоара)
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static List<T> QuickSort<T>(this List<T> list) where T : IComparable<T>
        {
            List<T> result = new(list);
            int left = 0;
            int right = result.Count - 1;
            SortArray(result, left, right);
            return result;
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
        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static List<T> Vstavka<T>(this List<T> list) where T : IComparable<T>
        {
            List<T> result = new(list);
            for (int i = 1; i < result.Count; i++)
            {
                T k = result[i];
                int j = i - 1;
                while (j >= 0 && result[j].CompareTo(k) > 0)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = k;
            }
            return result;
        }
        /// <summary>
        /// Сортировка слиянием
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        public static List<T> Sliyaniesort<T>(this List<T> list) where T : IComparable<T>
        {
            List<T> result = new(list);
            int left = 0;
            int right = result.Count - 1;
            Mergesort(result, left, right);
            return result;
        }
        /// <summary>
        /// вспомогательный метод для сортировки слиянием
        /// </summary>
        /// <typeparam name="T">тип элементов списка</typeparam>
        /// <param name="list">список элементов</param>
        /// <param name="left">левая граница</param>
        /// <param name="right">правая граница</param>
        static void Mergesort<T>(this List<T> list, int left, int right) where T : IComparable<T>
        {
            if (right - left > 1)
            {
                int a1 = left;
                int b1 = (left + right) / 2;
                int a2 = (left + right) / 2 + 1;
                int b2 = right;
                Mergesort(list, a1, b1);
                Mergesort(list, a2, b2);
                T[] t = new T[right - left + 1];
                for (int k = left; k <= right; k++)
                    t[k - left] = list[k];
                int i = a1;
                int j = a2;
                for (int k = left; k <= right; k++)
                {
                    if (i <= b1 && j <= b2)
                    {
                        if (t[i - left].CompareTo(t[j - left]) < 0)
                        {
                            list[k] = t[i - left];
                            i++;
                        }
                        else
                        {
                            list[k] = t[j - left];
                            j++;
                        }
                    }
                    else
                    {
                        if (i > b1)
                        {
                            list[k] = t[j - left];
                            j++;
                        }
                        else
                        {
                            list[k] = t[i - left];
                            i++;
                        }
                    }
                }
            }
            else
            {
                if (right - left == 1)
                    if (list[left].CompareTo(list[right]) > 0)
                        (list[left], list[right]) = (list[right], list[left]);
            }
        }

    }
}