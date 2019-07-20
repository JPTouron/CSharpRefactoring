using System;

namespace Refactoring_07_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// que hicimos:
        /// creamos metodos de extension, para decimales (para usarlos para el parametro price en este caso)
        /// de esa forma podemos tener metodos como ApplyDiscountForAccountStatus que sean aplicables a price
        /// y asi organizar la forma en que los descuentos se aplican y aislar a esta clase de la responsabilidad de saber
        /// cómo se calculan los descuentos
        /// </summary>
        public decimal Calculate(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;

                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS)
                      .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;

                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS)
                      .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;

                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS)
                      .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;

                default:
                    throw new InvalidOperationException($"El parametro accountStatus no tiene un valor válido, valor actual: {accountStatus}");
            }
            return priceAfterDiscount;
        }
    }
}