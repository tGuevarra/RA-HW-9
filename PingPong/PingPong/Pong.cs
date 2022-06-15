namespace PingPong
{
    public class Pong
    {
        public Ping Partner { get; set; }

        public delegate void PongEvent();
        public event PongEvent SendPong;

        public void OnPing()
        {
            Random _rnd = new Random();
            int magicNumber = _rnd.Next(0, 10);

            if (magicNumber > 1)
            {
                Console.WriteLine("Pong получил Ping...");
                SendPong?.Invoke();
            }
            else
            {
                Program.continuePlay = false;
                Console.WriteLine("Pong промахнулся! Победил Ping!");            
            }
        }

        public void AddPing(Ping ping)
        {
            ping.SendPing += OnPing;
        }
    }
}
