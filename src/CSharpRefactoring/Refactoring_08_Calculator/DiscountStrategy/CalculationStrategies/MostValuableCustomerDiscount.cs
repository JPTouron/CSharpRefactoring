using Refactoring_08_Calculator.DiscountStrategy.Base;

namespace Refactoring_08_Calculator.DiscountStrategy.CalculationStrategies
{
    public class MostValuableCustomerDiscount : BaseDiscountStrategy
    {
        public MostValuableCustomerDiscount(decimal price, int timeOfHavingAccountInYears) : base(price, timeOfHavingAccountInYears)
        {
        }

        public override decimal CalculateDiscount()
        {
            var discountForStatus = ApplyDiscountForAccountStatus(price, Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS);
            var priceAfterDiscount = ApplyDiscountForTimeOfHavingAccount(discountForStatus, timeOfHavingAccountInYears);

            return priceAfterDiscount;
        }
    }
}