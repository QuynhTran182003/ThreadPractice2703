namespace Cv2703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hrac h = new Hrac("Krixi", 500);
            Thread thread1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    h.DecreaseHealth(new Random().Next(500)+100);
                }
            }
            ));

            Thread thread2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    h.IncreaseHealth(new Random().Next(50));
                }
            }
            ));
            thread1.Start();
            thread2.Start();
        }
    }
}