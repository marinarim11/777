 const int DIM = 3;


    var A = InitializationMatrix();
    Thread.Sleep(100);
    var B = InitializationMatrix();
Console.WriteLine("Результат");
    var C = MultiplicationMatrix(A, B);

 static int[,] InitializationMatrix()
{
    var matrix = new int[DIM, DIM];

    var rand = new Random();

    for (int i = 0; i < DIM; i++)
    {
        for (int j = 0; j < DIM; j++)
        {
            matrix[i, j] = rand.Next(1, 15);
            Console.Write(matrix[i, j] + ", ");
        }
        Console.WriteLine();
    }

    return matrix;
}
 static int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    var resultMatrix = new int[DIM, DIM];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            Console.Write(resultMatrix[i, j] + ", ");
        }
        Console.WriteLine();
    }

    return resultMatrix;
}

