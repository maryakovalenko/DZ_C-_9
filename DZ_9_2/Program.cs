// Знакомство с языками программирования домашняя работа к уроку 9. Как не нужно писать код.
Console.WriteLine("Задача № 66");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSumm(m, n, temp=0);
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
