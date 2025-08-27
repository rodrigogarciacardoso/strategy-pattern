using strategy_pattern.Contracts;

namespace strategy_pattern.Service
{
    public class TaxCalculatorService(TaxTypeInterface taxTypeInterface)
    {
        private readonly TaxTypeInterface _taxTypeInterface = taxTypeInterface;

        public decimal Calculate(decimal amount)
        {
            return _taxTypeInterface.Calculate(amount);
        }
    }
}
