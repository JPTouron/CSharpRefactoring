using Refactoring_08_Calculator.DiscountStrategy.Base;
using System;

namespace Refactoring_08_Calculator.DiscountStrategy.CalculationStrategies
{
    public class NotRegisteredDiscount : BaseDiscountStrategy
    {
        public NotRegisteredDiscount(decimal price, int timeOfHavingAccountInYears) : base(price, timeOfHavingAccountInYears)
        {
        }

        public override decimal CalculateDiscount()
        {
            var priceAfterDiscount = base.price;
            return priceAfterDiscount ;
        }
    }
}