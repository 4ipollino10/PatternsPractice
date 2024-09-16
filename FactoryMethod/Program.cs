using FactoryMethod.Factories;
using FactoryMethod.Payments;

var payments = new List<IPayment>();

var paymentFactory = new PaymentFactory();

payments.Add(paymentFactory.CreatePayment(Payment.PayPal));
payments.Add(paymentFactory.CreatePayment(Payment.CreditCard));
payments.Add(paymentFactory.CreatePayment(Payment.PayPal));
payments.Add(paymentFactory.CreatePayment(Payment.CreditCard));

foreach (var payment in payments)
{
    payment.GetSystem();
}
