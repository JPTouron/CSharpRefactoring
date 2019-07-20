namespace Refactoring_02_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// que hicimos:
        /// agregamos un enumerado: AccountStatus, que nos permite dar más significado al codigo y hacerlo mas legible
        /// </summary>
        public decimal Calculate(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > 5) ? (decimal)5 / 100 : (decimal)timeOfHavingAccountInYears / 100;

            if (accountStatus == AccountStatus.NotRegistered)
            {
                priceAfterDiscount = price;
            }
            else if (accountStatus == AccountStatus.SimpleCustomer)
            {
                priceAfterDiscount = (price - (0.1m * price)) - (discountForLoyaltyInPercentage * (price - (0.1m * price)));
            }
            else if (accountStatus == AccountStatus.ValuableCustomer)
            {
                priceAfterDiscount = (0.7m * price) - (discountForLoyaltyInPercentage * (0.7m * price));
            }
            else if (accountStatus == AccountStatus.MostValuableCustomer)
            {
                priceAfterDiscount = (price - (0.5m * price)) - (discountForLoyaltyInPercentage * (price - (0.5m * price)));
            }
            return priceAfterDiscount;
        }
    }
}