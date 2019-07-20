using Refactoring_08_Calculator.DiscountStrategy.Factory;

namespace Refactoring_08_Calculator
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

            var factory = new StragetyFactory();
            var discountStragegy = factory.GetStrategy(price, accountStatus, timeOfHavingAccountInYears);

            priceAfterDiscount = discountStragegy.CalculateDiscount();

            return priceAfterDiscount;
        }
    }
}