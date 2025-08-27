using strategy_pattern.Contracts;

namespace strategy_pattern.Service
{
    public class ISS : TaxTypeInterface
    {
        public decimal Calculate(decimal amount)
        {
            return (amount * 11) / 100;
        }
    }
}
