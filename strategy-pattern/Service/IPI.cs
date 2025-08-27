using strategy_pattern.Contracts;

namespace strategy_pattern.Service
{
    public class IPI : TaxTypeInterface
    {
        public decimal Calculate(decimal amount)
        {
            return (amount * 15) / 100;
        }
    }
}
