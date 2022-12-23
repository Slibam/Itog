void Zadanie3()
{
    string[] numbers = new string[] { "Moskva", "Peter", "I", "It", "Car", "Up" };
    FillArrau(numbers);

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
Zadanie3();