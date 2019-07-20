using Refactoring_08_Calculator.DiscountStrategy.Base;
using Refactoring_08_Calculator.DiscountStrategy.CalculationStrategies;
using System;

namespace Refactoring_08_Calculator.DiscountStrategy.Factory
{
    public class StragetyFactory
    {
        public BaseDiscountStrategy GetStrategy(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    return new NotRegisteredDiscount(price, timeOfHavingAccountInYears);

                case AccountStatus.SimpleCustomer:
                    return new SimpleCustomerDiscount(price, timeOfHavingAccountInYears);

                case AccountStatus.ValuableCustomer:
                    return new ValuableCustomerDiscount(price, timeOfHavingAccountInYears);

                case AccountStatus.MostValuableCustomer:
                    return new MostValuableCustomerDiscount(price, timeOfHavingAccountInYears);

                default:
                    throw new InvalidOperationException($"El parametro accountStatus no tiene un valor válido, valor actual: {accountStatus}");
            }
        }
    }
}