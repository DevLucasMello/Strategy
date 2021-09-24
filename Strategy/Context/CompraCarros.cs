using System;
using Strategy.Strategy;
using Strategy.StrategyA;

namespace Strategy.Context
{
    public class CompraCarros
    {
        private readonly Carro _carro;
        private readonly int _tipoCompra;
        private readonly IDesconto _desconto;

        public CompraCarros(Carro carro, TipoCompra tipoCompra)
        {
            _carro = carro;
            _tipoCompra = (int)tipoCompra;
            _desconto = TipoDesconto(_tipoCompra);
        }

        public decimal ValorDesconto()
        {
            var valorDesconto = _desconto.Desconto(_carro);
            return valorDesconto;
        }

        public IDesconto TipoDesconto(int tipoCompra)
        {
            switch (tipoCompra)
            {
                case 1: return new PagamentoAVista();
                case 2: return new PagamentoCartao();
                case 3: return new PagamentoFinanciamento();
                default: throw new ApplicationException("Não foi possível identificar a forma de pagamento");
            }

        }   
    }
}
