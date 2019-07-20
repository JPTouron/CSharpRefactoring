namespace Refactoring_08_Calculator.DiscountStrategy.Base
{
    public abstract class BaseDiscountStrategy
    {
        protected decimal price;

        protected int timeOfHavingAccountInYears;

        public BaseDiscountStrategy(decimal price, int timeOfHavingAccountInYears)
        {
            this.price = price;
            this.timeOfHavingAccountInYears = timeOfHavingAccountInYears;
        }

        public abstract decimal CalculateDiscount();

        protected decimal ApplyDiscountForAccountStatus(decimal price, decimal discountSize)
        {
            return price - (discountSize * price);
        }

        protected decimal ApplyDiscountForTimeOfHavingAccount(decimal price, int timeOfHavingAccountInYears)
        {
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY) ? (decimal)Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100 : (decimal)timeOfHavingAccountInYears / 100;
            return price - (discountForLoyaltyInPercentage * price);
        }
    }
}