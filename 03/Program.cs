// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



using static System.Console;
Clear();


int[,] matrix = GetMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
int[] newLine = GetLine(matrix);
WriteLine();
WriteLine(String.Join(" ", newLine));
int number = newLine[0];
int count = 1;
for (int i = 1; i < newLine.Length; i++)
{
    if(newLine[i] == number) count++;
    else 
    {
        WriteLine($"Число {number} встретилось {count} раз");
        number = newLine[i];
        count = 1;
    } 
}
WriteLine($"Число {number} встретилось {count} раз");








// if(matrix.GetLength(0) == matrix.GetLength(1)) PrintMatrix (ReverseMatrix1(matrix));
// else WriteLine("Это невозможно");
// WriteLine();

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

