using Strategy.Context;

namespace Strategy.Strategy
{
    public interface IDesconto
    {        
        decimal Desconto(Carro carro);
    }
}
