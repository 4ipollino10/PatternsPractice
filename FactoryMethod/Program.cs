using FactoryMethod.Factories;
using FactoryMethod.Payments;

var payments = new List<IPayment>();
var payPalFactory = new PayPalPaymentFactory(); 
var payPalPayment = payPalFactory.CreatePayment();

var creditCardFactory = new CreditCardPaymentFactory(); 
var creditCardPayment = creditCardFactory.CreatePayment();

payments.Add(payPalPayment);
payments.Add(creditCardPayment);

foreach (var payment in payments)
{
    payment.GetSystem();
}
