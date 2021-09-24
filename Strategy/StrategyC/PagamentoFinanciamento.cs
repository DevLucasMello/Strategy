using Strategy.Context;
using Strategy.Strategy;

namespace Strategy.StrategyA
{
    public class PagamentoFinanciamento : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 5 / 100;
        }
    }
}
