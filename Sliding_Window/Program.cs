class Program
{

    static int maxSum(int[] arr, int arrLength, int windows_Size)
    {

        // Edge case 
        if (arrLength < windows_Size)
        {
            Console.WriteLine("Invalid");
            return -1;
        }

        // Compute sum of first window of size for given windows_Size
        int max_sum = 0;
        for (int index = 0; index < windows_Size; index++)
            max_sum += arr[index];

     // sliding windows technique
        int window_sum = max_sum;
        for (int index = windows_Size; index < arrLength; index++)
        {
            window_sum = window_sum+ arr[index] - arr[index - windows_Size];
            max_sum = Math.Max(max_sum, window_sum);
        }

        return max_sum;
    }

    // Driver code
    public static void Main()
    {
        int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
        int window_size = 4;
        int arrLength = arr.Length;
        Console.WriteLine(maxSum(arr, arrLength, window_size));
    }
}
