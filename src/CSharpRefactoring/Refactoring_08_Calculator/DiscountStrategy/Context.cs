using Refactoring_08_Calculator.DiscountStrategy.Base;

namespace Refactoring_08_Calculator.DiscountStrategy
{
    public class Context : IContext

    {
        private BaseDiscountStrategy _strategy;

        // Constructor

        public Context(BaseDiscountStrategy strategy)
        {
            this._strategy = strategy;
        }

        public decimal CalculateDiscount()
        {
            return _strategy.CalculateDiscount();
        }
    }
}