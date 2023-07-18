 int[,] matrix = {{3,4,5},
                            {2,3,4},
                            {7,4,2},
                            {2,3,7}};

    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < 4; i++)
    {
        int temp = 0;
        for (int j = 0; j < 3; j++)
        {
            temp += matrix[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка: " + index + " Сумма - " + sum);
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
        Console.Write(matrix[index, i] + " ");

    }
    Console.ReadKey();
