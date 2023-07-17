int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void GetSumNumber(int a)
{
       Console.WriteLine("Таблица кубов чисел от 1 до a:");
            for (int i = 1; i <= a; i++)
            {
                int cube = CalculateCube(i);
                Console.Write(cube + " ");
            }
}

int CalculateCube(int number)
        {
            return number * number * number;
        }

int A = GetNumber("Введите число: ");
GetSumNumber(A);


