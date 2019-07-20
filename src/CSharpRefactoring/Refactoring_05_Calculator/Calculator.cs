using System;

namespace Refactoring_05_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// que hicimos:
        /// para el accountstatus = valuable customer, modificamos la regla constante: 0.7m * price por una regla que sea igual a todas las otras
        /// price - 0.3m * price
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
                    priceAfterDiscount = (price - 0.3m * price);
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
