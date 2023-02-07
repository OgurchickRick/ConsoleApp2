namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = { { 1, 1, 7 },
                            { 3, 4, 6 },
                            { 5, 8, 9 } };
            int x = 0;
            int rows = nums.GetUpperBound(0) + 1;  
            int columns = nums.Length / rows;
            int[] res = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (nums[i, j] % 2 != 0) 
                    {
                        x = nums[i, j];
                    }
                }
                res[i] = x;
                x = 0;
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} \t");
            }
        }
    }
}