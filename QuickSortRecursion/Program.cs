namespace QuickSortRecursion;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 4, 1, 6, 7, 8, 5, 9, 3, 0 };
        foreach (var item in QuickSort(array))
        {
            Console.Write($"{item} ");
        }
        Console.ReadLine();
    }
    static int[] QuickSort(int[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }
        else
        {
            int pivot = array[0];
            var less = array.Where(x => x < pivot).ToArray();
            var greater = array.Where(x => x > pivot).ToArray();
            List<int> result = new();
            result.AddRange(QuickSort(less));
            result.Add(pivot);
            result.AddRange(QuickSort(greater));
            return result.ToArray();
        }
    }
}

