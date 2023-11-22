using Hw2;

//get nominal of trade
    
    int nominal = Calculations.GetNominal();//Int32.Parse(Console.ReadLine());

//get trade price
    
    double price = Calculations.GetPrice();

//get Transaction Type for trade
    
    string transType = Calculations.GetTransactionType();

    TransactionType trcType;
    trcType = (TransactionType) Enum.Parse(typeof(TransactionType), transType, true);

// calculate current value     
    double currentValue = Calculations.CalculateCurrentValue((int)trcType, nominal, price);

// display result for user
    Calculations.ShowResult(transType, nominal, price, currentValue);
