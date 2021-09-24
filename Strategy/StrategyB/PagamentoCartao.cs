using Strategy.Context;
using Strategy.Strategy;

namespace Strategy.StrategyA
{
    public class PagamentoCartao : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 10 / 100;
        }
    }
}
