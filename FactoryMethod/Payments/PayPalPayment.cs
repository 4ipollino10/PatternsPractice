namespace FactoryMethod.Payments;

public class PayPalPayment : IPayment
{
    public void GetSystem()
    {
        Console.WriteLine("PayPal");
    }
}