namespace UnitTests
{
    public static class ManualCalculations
    {
        /// <summary>
        /// hacemos el calculo "a mano" del descuento que aplica la clase Calculator y que almacena en su variable interna 'disc'
        /// </summary>
        public static decimal CalculateDiscountBasedOnYears(int years)
        {
            return (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
        }

        /// <summary>
        /// hacemos el calculo "a mano" que hace la calculadora cuando le pasan Type=2 por parametro
        /// </summary>
        public static decimal CalculateFinalResultWithType2(decimal amount, decimal disc)
        {
            return (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
        }

        /// <summary>
        /// hacemos el calculo "a mano" que hace la calculadora cuando le pasan Type=3 por parametro
        /// </summary>
        public static decimal CalculateFinalResultWithType3(decimal amount, decimal disc)
        {
            return (0.7m * amount) - disc * (0.7m * amount);
        }

        /// <summary>
        /// hacemos el calculo "a mano" que hace la calculadora cuando le pasan Type=4 por parametro
        /// </summary>
        public static decimal CalculateFinalResultWithType4(decimal amount, decimal disc)
        {
            return (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
        }
    }
}