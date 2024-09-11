using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public abstract class PaymentFactory
{
    public abstract IPayment CreatePayment();
}