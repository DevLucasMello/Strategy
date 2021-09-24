namespace Strategy.Context
{
    public class Carro
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Carro(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
