namespace CSharpBasicsAssignment;

public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public decimal DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public decimal CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice;

        TotalPrice -= TotalPrice * (decimal)(DiscountPercent / 100);

        return TotalPrice;
    }
  
    public void PrintSummary()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Unit Price: {UnitPrice:C}");
        Console.WriteLine($"Total Price: {TotalPrice:C}");
        Console.WriteLine($"Is Paid: {IsPaid}");
        Console.WriteLine($"Discount Percent: {DiscountPercent}%");
        Console.WriteLine($"Shipping City: {ShippingCity}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"Item Code: {ItemCode}");
    }

}
