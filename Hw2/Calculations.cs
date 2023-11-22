
    public class Calculations
    {
        public static int GetNominal()
        {
            Console.WriteLine("Input the nominal of the trade:");
            int nominal = Int32.Parse(Console.ReadLine());
            return nominal;
        }

        public static double GetPrice()
        {
            Console.WriteLine("Input trade price:");
            double price = Double.Parse(Console.ReadLine());
            return price;
        }

        public static string GetTransactionType()
        {
            Console.WriteLine("Input Transaction Type (Buy or Sell) of the trade:");
            string transType = Console.ReadLine();
            return transType;
        }

        public static double CalculateCurrentValue(int a, int b, double c)
        {
            double value = a * b * c;
            return value;

        }

        public static void ShowResult(string transType, int nominal, double price, double currentValue)
        {
            Console.Clear();
            Console.WriteLine($" \n\rTransaction details:\n\rNominal = {nominal}" +
                              $" \n\rPrice = {price}" +
                              $" \n\rType  = {transType}" +
                              $" \n\rCurrent value is: {currentValue}");
        }
    }
