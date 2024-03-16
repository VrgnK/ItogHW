using System;




    class Program
    {
    static void Main()
    {
    /// сформировал блок-схему кода 
    ///string imagePath = "obj/BlokEnd.png";
    {
        Console.Write("Введите количество элементов в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

 for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = Console.ReadLine();
        }

        string[] result = FilterArray(array);

        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] array)
    {
        int count = 0;

        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
                
        string[] result = new string[count];
                int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
}