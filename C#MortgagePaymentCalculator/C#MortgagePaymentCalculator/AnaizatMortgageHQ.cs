class AnaizatMortgageHQ
{
    static void Main()
    {
        Console.Title = "Mortgage Loan Calculator";

        // Step 1. Gather Inputs
        Console.Write("Enter the home purchase price: $");
        decimal purchasePrice = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the market value of the home: $");
        decimal marketValue = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the down payment: $");
        decimal downPayment = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the annual interest rate (e.g., 6 for 6%): ");
        decimal annualInterestRate = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the loan term in years (15 or 30): ");
        int loanTerm = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the yearly HOA fee (if any): $");
        decimal yearlyHOA = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter the buyer's monthly income: $");
        decimal monthlyIncome = decimal.Parse(Console.ReadLine() ?? "0");

        // Step 2. Calculate loan amount
        decimal loanAmount = purchasePrice - downPayment;

        // Calculate equity percentage
        decimal equity = (marketValue - loanAmount) / marketValue;

        // Determine loan insurance equal to 1% of loan amount (applicable if equity < 10%)
        bool needsInsurance = equity < 0.10m;
        decimal yearlyLoanInsurance = needsInsurance ? loanAmount * 0.01m : 0m;
        decimal monthlyLoanInsurance = yearlyLoanInsurance / 12;

        // Calculate escrow components: 1.25% tax + 0.75% insurance of market value per year
        decimal yearlyPropertyTax = marketValue * 0.0125m;
        decimal yearlyHomeownersInsurance = marketValue * 0.0075m;
        decimal yearlyEscrow = yearlyPropertyTax + yearlyHomeownersInsurance;
        decimal monthlyPropertyTax = yearlyPropertyTax / 12;
        decimal monthlyHomeownersInsurance = yearlyHomeownersInsurance / 12;
        decimal monthlyEscrow = yearlyEscrow / 12;

        // Monthly HOA
        decimal monthlyHOA = yearlyHOA / 12;

        // Calculate monthly mortgage payment
        int numberOfPayments = loanTerm * 12;
        decimal monthlyInterestRate = annualInterestRate / 100 / 12;

        decimal numerator = loanAmount * monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, numberOfPayments);
        decimal denominator = (decimal)Math.Pow(1 + (double)monthlyInterestRate, numberOfPayments) - 1;
        decimal baseMonthlyPayment = denominator == 0 ? 0 : numerator / denominator;

        decimal totalMonthlyPayment = baseMonthlyPayment + monthlyEscrow + monthlyHOA + monthlyLoanInsurance;
        decimal incomeRatio = totalMonthlyPayment / monthlyIncome;

        // Output Summary
        Console.WriteLine("\n=== Mortgage Summary ===");
        Console.WriteLine($"Loan Amount: {loanAmount:C2}");
        Console.WriteLine($"Equity: {equity:P2}");
        Console.WriteLine($"Loan Insurance Required: {needsInsurance}");
        Console.WriteLine($"Base Monthly Payment (Principal + Interest): {baseMonthlyPayment:C2}");
        Console.WriteLine($"Monthly Escrow (Tax + Insurance): {monthlyEscrow:C2}");
        Console.WriteLine($"  - Property Tax: {monthlyPropertyTax:C2}");
        Console.WriteLine($"  - Homeowner's Insurance: {monthlyHomeownersInsurance:C2}");
        Console.WriteLine($"Monthly HOA: {monthlyHOA:C2}");
        Console.WriteLine($"Monthly Loan Insurance: {monthlyLoanInsurance:C2}");
        Console.WriteLine($"Total Monthly Payment: {totalMonthlyPayment:C2}");
        Console.WriteLine($"Income Ratio: {incomeRatio:P2}");

        if (incomeRatio >= 0.25m)
        {
            Console.WriteLine("\nLoan Denied.");
            Console.WriteLine("\nWe understand that receiving a loan denial can be disappointing. \nAt Anaizat Strategic Military Mortgages, we're committed to helping you achieve homeownership. \nConsider these options: \n1. Increase your down payment to reduce the loan amount \n2. Explore more affordable properties within your budget \n3. Improve your debt-to-income ratio \n4. Speak with our loan specialists about alternative financing programs designed for military families");
        }
        else
        {
            Console.WriteLine("\nLoan Approved.");
            Console.WriteLine("\nCongratulations! Your loan application has been approved by Anaizat Strategic Military Mortgages. We're honored to support your homeownership journey and look forward to helping you secure your new home. Your dedicated service deserves a place to call home.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}