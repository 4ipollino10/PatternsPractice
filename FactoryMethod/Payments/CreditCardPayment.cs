namespace FactoryMethod.Payments;

public class CreditCardPayment : IPayment
{
    public void GetSystem()
    {
        Console.WriteLine("CreditCard");
    }
}