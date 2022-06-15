namespace RA_HW_9
{
    public class Program
    {
        public static void Main()
        {
                try
                {
                    Console.Write("Выберите число от 1 до 100: ");
                    int count = int.Parse(Console.ReadLine());

                    if (count < 1 || count > 100) throw new Exception();

                    Counter counter = new(count);

                    Handler1 handler1 = new(counter);
                    Handler2 handler2 = new(counter);

                    counter.StartCount();

                    Console.WriteLine("Все операции выполнены");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }
        }
}


