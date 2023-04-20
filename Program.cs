namespace ThreadTaskExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Met1();
            Met2();
            Met3();
            Console.ReadKey();
        }
        static async Task Met1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Met111");
                    Task.Delay(100).Wait();
                }
            });
        }
        static async Task Met2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Met222");
                    Task.Delay(100).Wait();
                }
            });
        }
        static async Task Met3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Met333");
                    Task.Delay(100).Wait();
                }
            });
        }
    }
}







