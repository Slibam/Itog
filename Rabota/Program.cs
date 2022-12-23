void Zadanie3()
{
    string[] numbers = new string[] { "Moskva", "Peter", "I", "It", "Car", "Up" };
    FillArrau(numbers);
    Sravn(numbers);
}
void FillArrau(string[] nums)
{
    Console.WriteLine("Дан массив слов:");
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{nums[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void Sravn(string[] nums)
{
    Console.WriteLine("Слова с длинной букв меньше либо ровны 3м символам");
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        if (nums[i].Length <= 3)
        {
            Console.Write($"{nums[i]}, ");
        }
    }
}
Zadanie3();