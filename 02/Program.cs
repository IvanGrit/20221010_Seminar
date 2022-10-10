// **Задача 55:** Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

using static System.Console;
Clear();


int[,] matrix = GetMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
WriteLine();
if(matrix.GetLength(0) == matrix.GetLength(1)) PrintMatrix (ReverseMatrix1(matrix));
else WriteLine("Это невозможно");
WriteLine();



int[,] ReverseMatrix(int[,] table)
{
   int[,] resultMatrix = new int[table.GetLength(1), table.GetLength(0)]; 
   for (int i = 0; i < table.GetLength(0)-1; i++)
   {
    for (int j = 0; j < table.GetLength(1); j++)
    {
        resultMatrix[j,i] = table[i,j];
    }
   }
   return resultMatrix;
}


int[,] ReverseMatrix1(int[,] table)
{
   
   for (int i = 0; i < table.GetLength(0)-1; i++)
   {
    for (int j = i; j < table.GetLength(1); j++)
    {
        int temp = table[j,i];
        table[j,i] = table[i,j];
        table[i,j] = temp;
    }
   }
   return table;
}



int[,] GetMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue,maxValue+1);           
        }

    }
    return resultMatrix;
}

void ReplaseMatrix(int[,] m)
{
    int lastLine = m.GetLength(0)-1; // узнаем индекс последней строки
    for (int i = 0; i < m.GetLength(1); i++)
    {
        int temp = m[0,i];
        m[0,i] = m[lastLine,i];
        m[lastLine,i] = temp;
    }
}

void PrintMatrix(int[,] inMatrix) 
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]}\t");
        }
        WriteLine();
    }
}