using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public class CreditCardPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}