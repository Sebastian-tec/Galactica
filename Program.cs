namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            StockData data = new StockData();

            data.PrintStar();
            data.PrintPlanets();
            data.PrintMoons();
            Console.ReadKey();

        }
    }
}