using Strategy.Context;
using Strategy.Strategy;

namespace Strategy.StrategyA
{
    public class PagamentoAVista : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 15 / 100;
        }
    }
}
