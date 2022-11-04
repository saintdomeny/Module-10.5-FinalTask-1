namespace Module_10._5_FinalTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum calculateSum = new CalculateSum();
            int a, b;
            try
            {
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());

                var result = ((ISum)calculateSum).Sum(a, b);
                Console.WriteLine("Result:" + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    public interface ISum
    {
        public int Sum(int one, int two);
    }

    public class CalculateSum : ISum
    {
        int ISum.Sum(int one, int two)
        {
            return one + two;
        }
    }
}