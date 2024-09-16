using FactoryMethod.Payments;

namespace FactoryMethod.Factories;

public interface ICreator
{
    public IPayment CreatePayment();
}