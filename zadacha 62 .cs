// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).
int sizeX = 4;
int sizeY = 4;
int[,] array = new int[sizeX, sizeY];
int indexX = 0;
int indexY = 0;

int changeX = 0;
int changeY = 1;
int steps = sizeY;
int directoin = 0;

for (int i = 0; i < array.Length; i++)
{
    array[indexX, indexY] = i + 1;
    steps--;
    if (steps == 0)
    {
        steps = sizeY * ((directoin) % 2) + sizeX * ((directoin + 1) % 2) - 1 - directoin / 2;
        int temp = changeX;
        changeX = changeY;
        changeY = -temp;
        directoin++;
    }

    indexX += changeX;
    indexY += changeY;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}