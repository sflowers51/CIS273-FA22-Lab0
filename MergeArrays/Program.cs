namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] array3 = new int[10];
            foreach (int i in array1)
            {
                array3[i] = i;
            }
            foreach (int i in array2)
            {
                array3[i] = i;
            }
            return array3;
        }
    }

}