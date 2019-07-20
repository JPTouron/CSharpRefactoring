using Refactoring_08_Calculator.DiscountStrategy.Factory;

namespace Refactoring_08_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// que hicimos:
        /// Utilizando el patron de diseño strategy: https://www.dofactory.com/net/strategy-design-pattern
        /// pudimos reemplazar cada caso del switch por una clase especializada en calcular el descuento de una forma concreta
        /// de esta forma ganamos:
        ///     simplicidad en este metodo y una unica responsabilidad: invocar el calculador apropiado
        ///     mantener el funcionamiento original intacto (todos los UTs pasan ok)
        ///     que cada responsabilidad tenga su clase, garantizando clases que solo tienen una sola responsabilidad
        ///     hacer mas agnóstico este metodo: este metodo no sabe como se calcula cada descuento
        ///     hacer mas simple el mantenimiento del metodo y los calculadores de descuento: no hay mas switches ni metodos raros de extension
        ///         si quiero modificar / agregar un descuento, modifico / agrego una clase mas en CalculationStrategies
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