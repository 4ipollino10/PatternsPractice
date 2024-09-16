using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public class PaymentFactory
{
    public IPayment CreatePayment(Payment type)
    {
        ICreator creator;
        
        switch (type)
        {
            case Payment.CreditCard:
                creator = new CreditCardPaymentCreator();
                break;
            case Payment.PayPal:
                creator = new PayPalPaymentCreator();
                break;
            default:
                throw new Exception("Необслуживаемый формат оплаты");
        }

        return creator.CreatePayment();
    }
}