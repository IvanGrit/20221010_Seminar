// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

sing static System.Console;
Clear();


int[,] matrix = GetMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
int[] min = FindMin


int[] FindMin (int[,] table1)
{
    int min = table1[0,0];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if(table1[i,j] < min) min = table1[i,j]; 
          int minI = i;
          int minJ = j;
        }
    }
    int[] result = {minI, minJ};
    return result;
}




int[] GetLine(int[,] matrix)
{
    int[] line = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            line[count] = matrix[i,j];
            count++;
        }
    }
    Array.Sort(line);
    return line;
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


