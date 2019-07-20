namespace Refactoring_00_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// estado inicial de la clase Calculator y metodo Calculate
        /// internamente este metodo no se entiende, es ilegible, y tiene estos problemas clave:
        /// los parametros de entrada no dicen por su solo nombre que hacen o significan
        /// sus variables internas no existen, por tanto encuentro numeros magicos por todos lados (ej:0.7, 4, 1, etc) que tampoco me cuenta su significado
        /// bug sutil introducido: qué pasa si el parametro type fuese 5? qué resultado obtendria? (asumamos que type es el tipo de cliente)
        /// el codigo en su gran mayoria o totalidad esta completamente repetido... las operaciones por cada type son casi las mismas...
        /// multiples repsponsabilidades en esta clase:
        ///     elegir el algoritmo de calculo
        ///     calcula un descuento segun un estado de cuenta (type)
        ///     calcula descuento segun la antigüedad del cliente (years)
        /// </summary>
        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;

            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }
    }
}