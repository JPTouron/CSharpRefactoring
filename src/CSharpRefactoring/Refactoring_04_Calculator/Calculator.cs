using System;

namespace Refactoring_04_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// que hicimos:
        /// agregamos una InvalidOperationException cuando el parametro accountStatus es inválido
        /// </summary>
        public decimal Calculate(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > 5) ? (decimal)5 / 100 : (decimal)timeOfHavingAccountInYears / 100;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;

                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = (price - (0.1m * price));
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;

                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = (0.7m * price);
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;

                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = (price - (0.5m * price));
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;

                default:
                    throw new InvalidOperationException($"El parametro accountStatus no tiene un valor válido, valor actual: {accountStatus}");
            }
            return priceAfterDiscount;
        }
    }
}
