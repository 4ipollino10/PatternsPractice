using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public class CreditCardPaymentCreator : ICreator
{
    public IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}