using Refactoring_08_Calculator.DiscountStrategy.Base;

namespace Refactoring_08_Calculator.DiscountStrategy.CalculationStrategies
{
    public class SimpleCustomerDiscount : BaseDiscountStrategy
    {
        public SimpleCustomerDiscount(decimal price, int timeOfHavingAccountInYears) : base(price, timeOfHavingAccountInYears)
        {
        }

        public override decimal CalculateDiscount()
        {
            var discountForStatus = ApplyDiscountForAccountStatus(price, Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS);
            var priceAfterDiscount = ApplyDiscountForTimeOfHavingAccount(discountForStatus, timeOfHavingAccountInYears);

            return priceAfterDiscount;
        }
    }
}