using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public class PayPalPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
    {
        return new PayPalPayment();
    }
}