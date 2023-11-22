using Hw2;

//get nominal of trade
    
    int nominal = Calculations.GetNominal();//Int32.Parse(Console.ReadLine());

//get trade price
    
    double price = Calculations.GetPrice();

//get booked price

    double bookedPrice = Calculations.GetBookedPrice();

//get Transaction Type for trade

    string transType = Calculations.GetTransactionType();

    TransactionType trcType = (TransactionType) Enum.Parse(typeof(TransactionType), transType, true);

// calculate current value     
    double currentValue = Calculations.CalculateCurrentValue((int)trcType, nominal, price);

// calculate profit or loss PL= 〖(Price〗_trade-〖Price〗_original)×Nominal   
    
    double profitLoss = (int)trcType < 1 ? Calculations.CalculateProfitLoss(price, bookedPrice, nominal) : 0;
    

// display result for user
    Calculations.ShowResult(transType, nominal, price, bookedPrice, currentValue, profitLoss);
