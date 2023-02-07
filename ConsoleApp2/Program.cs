namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите кол-во строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] nums = new int[rows, columns];
            int x = 0;
            int[] res = new int[rows];  
            bool isFlag = true;
            while (isFlag)
            {
                Console.WriteLine("Выберите способ ввода: ");
                Console.WriteLine("1 - ввод элементов в ручную");
                Console.WriteLine("2 - заполнение массива случайными числами");
                int wibor = Convert.ToInt32(Console.ReadLine());
                switch (wibor)
                {
                    case 1:
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write("Введите элемент массива: ");
                                nums[i, j] = Convert.ToInt32(Console.ReadLine());
                                if (nums[i, j] % 2 != 0)
                                {
                                    x = nums[i, j];
                                }
                            }
                            res[i] = x;
                            x = 0;
                        }
                        isFlag = false;
                        break;
                    case 2:
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                nums[i, j] = rnd.Next(-100, 100);
                                if (nums[i, j] % 2 != 0)
                                {
                                    x = nums[i, j];
                                }
                            }
                            res[i] = x;
                            x = 0;
                        }
                        isFlag = false;
                        break;
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} \t");
            }
        }
    }
}