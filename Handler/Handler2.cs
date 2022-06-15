namespace RA_HW_9
{
    public class Handler2
    {
        Counter _counter;
        public Handler2(Counter counter)
        {
            _counter = counter;
            _counter.Done += Complete;
        }

        public void Complete()
        {
            Console.Write("Обработчик закончил");
            Console.ReadLine();
        }
    }
}
