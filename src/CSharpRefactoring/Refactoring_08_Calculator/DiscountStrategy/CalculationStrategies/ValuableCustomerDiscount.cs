using Refactoring_08_Calculator.DiscountStrategy.Base;

namespace Refactoring_08_Calculator.DiscountStrategy.CalculationStrategies
{
    public class ValuableCustomerDiscount : BaseDiscountStrategy
    {
        public ValuableCustomerDiscount(decimal price, int timeOfHavingAccountInYears) : base(price, timeOfHavingAccountInYears)
        {
        }

        public override decimal CalculateDiscount()
        {
            var discountForStatus = ApplyDiscountForAccountStatus(price, Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS);
            var priceAfterDiscount = ApplyDiscountForTimeOfHavingAccount(discountForStatus, timeOfHavingAccountInYears);

            return priceAfterDiscount;
        }
    }
}