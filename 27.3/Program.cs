namespace _27._3
{
    internal class Program
    {
        public static Hrac h = new Hrac("Bruzek", 50);
        public static Random rd = new Random();
        public static string filePath = "C:\\Users\\zabransky\\Downloads\\dluznici.csv";
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Zvys));
            Thread t2 = new Thread(new ThreadStart(Sniz));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine(h.HP + " " + h.isAlive);
        }

        public static void Zvys()
        {
            for(int i = 0; i < 10; i++)
            {
                h.Zvysit(rd.Next(50));
            }
        }

        public static void Sniz()
        {
            for(int i = 0; i < 10; i++)
            {
                 h.Snizit(rd.Next(50));
            }
        }

        public void FindDluznik(int id)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();

        }
    }
}