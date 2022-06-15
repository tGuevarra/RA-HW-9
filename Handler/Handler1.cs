namespace RA_HW_9
{
    public class Handler1
    {
        Counter _counter;
        public Handler1(Counter counter)
        {
            _counter = counter;
            _counter.Done += Complete;
        }

        public void Complete()
        {
            Console.Write("Обработчик выполнен");
            Console.ReadLine();
        }
    }
}
