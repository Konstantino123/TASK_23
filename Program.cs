// Принимает число N и выдает квадраты чисел от 1 до N
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(),out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Введите не число или число равное нулю. Повторите ввод \n");
            }
    }
    return result;
}
void Square(int n)
{
for(int i=1; i <=n; i++)
{
    Console.Write($"{i*i},");
}
}
int number = GetNumber("Введите число N");
Square(number);