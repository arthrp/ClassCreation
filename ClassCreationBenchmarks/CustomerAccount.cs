namespace ClassCreationBenchmarks;

using System;

public class CustomerAccount
{
    public string CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string AccountType { get; set; }
    public string Region { get; set; }

    public int Age { get; set; }
    public int NumberOfOrders { get; set; }
    public int LoyaltyPoints { get; set; }
    public int AccountAgeInYears { get; set; }
    public int FailedLogins { get; set; }

    public long TotalSpent { get; set; }
    public long CreditLimit { get; set; }

    public bool IsActive { get; set; }
    public bool IsPremiumMember { get; set; }
    public bool EmailVerified { get; set; }
    
    public CustomerAccount()
    {
        // Initialize default values
        IsActive = true;
        IsPremiumMember = false;
        EmailVerified = false;
    }
    
    public bool IsEligibleForUpgrade()
    {
        return LoyaltyPoints > 1000 && TotalSpent > 50000 && IsActive && EmailVerified;
    }
    
    public double GetDiscountPercentage()
    {
        if (!IsActive) return 0;

        double discount = 0;

        if (IsPremiumMember) discount += 10;
        if (LoyaltyPoints > 500) discount += 5;
        if (TotalSpent > 100000) discount += 5;

        return discount;
    }
    
    public bool IsAccountAtRisk()
    {
        return FailedLogins > 5 || !EmailVerified || AccountAgeInYears < 1;
    }
    
    public void PrintAccountSummary()
    {
        Console.WriteLine($"Customer: {Name} ({CustomerId})");
        Console.WriteLine($"Email: {Email} - Verified: {EmailVerified}");
        Console.WriteLine($"Account Type: {AccountType}, Premium: {IsPremiumMember}");
        Console.WriteLine($"Total Spent: {TotalSpent}, Loyalty Points: {LoyaltyPoints}");
        Console.WriteLine($"Eligible for Upgrade: {IsEligibleForUpgrade()}");
        Console.WriteLine($"Discount Available: {GetDiscountPercentage()}%");
        Console.WriteLine($"Account Risk Flagged: {IsAccountAtRisk()}");
    }
}