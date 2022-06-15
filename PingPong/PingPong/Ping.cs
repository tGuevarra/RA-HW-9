namespace PingPong
{
    public class Ping
    {
        public Pong Partner { get; set; }

        public delegate void PingEvent();
        public event PingEvent SendPing;

        public void OnPong()
        {
            Random _rnd = new Random();
            int magicNumber = _rnd.Next(0, 10);

            if (magicNumber > 2)
            {
                Console.WriteLine("Ping получил Pong...");
                SendPing?.Invoke();
            }
            else
            {
                Program.continuePlay = false;
                Console.WriteLine("Ping промахнулся! Победил Pong!");
            }
        }

        public void AddPong(Pong pong)
        {
            pong.SendPong += OnPong;
        }
    }
}
