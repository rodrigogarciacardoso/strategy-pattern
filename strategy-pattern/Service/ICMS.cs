using strategy_pattern.Contracts;

namespace strategy_pattern.Service
{
    public class ICMS : TaxTypeInterface
    {
        public decimal Calculate(decimal amount)
        {
            return (amount * 4) / 100;
        }
    }
}
