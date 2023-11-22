
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

        public static double GetBookedPrice()
        {
            Console.WriteLine("Input Booked price:");
            double bookedPrice = Double.Parse(Console.ReadLine());
            return bookedPrice;
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

    //PL= 〖(Price〗_trade-〖Price〗_original)×Nominal
    public static double CalculateProfitLoss(double a, double b, int c)
        {
            double value = (a - b) * c;
            return value;

        }

    public static void ShowResult(string transType, int nominal, double price,double bookedPrice, double currentValue,double profitLoss)
        {
            Console.Clear();
            Console.WriteLine($" \n\rTransaction details:\n\rNominal = {nominal}" +
                              $" \n\rPrice = {price}" +
                              $"\n\rBooked Price = {bookedPrice}" +
                              $" \n\rTransaction Type  = {transType}" +
                              $" \n\rCurrent value is: {currentValue}");

            if (profitLoss != 0)
            {
                Console.WriteLine($"\n\rProfit Loss value is: {profitLoss}");
            }
            else
            {
                 Console.WriteLine("\n\rProfit Loss value is not calculated for Buy transaction type");
            }
            
        }
    }
