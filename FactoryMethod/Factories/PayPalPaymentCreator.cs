using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public class PayPalPaymentCreator : ICreator
{
    public IPayment CreatePayment()
    {
        return new PayPalPayment();
    }
}