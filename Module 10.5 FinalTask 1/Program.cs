namespace Module_10._5_FinalTask_1
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            CalculateSum calculateSum = new CalculateSum(Logger);
            int a, b;
            try
            {
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());

                var result = ((ISum)calculateSum).Sum(a, b);//Logger.Event Внутри метода синим цветом.
                Console.WriteLine("Result:" + result);
            }
            catch (Exception ex)
            {
                Logger.Error("Exception thrown:"); //Логирование ошибки красным цветом
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}