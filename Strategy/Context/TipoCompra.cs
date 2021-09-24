using System.ComponentModel;

namespace Strategy.Context
{
    public enum TipoCompra
    {
        [Description("1 - Pagamento à vista")]        
        AVista = 1,
        [Description("2 - Pagamento com cartão de crédito")]
        Cartao = 2,
        [Description("3 - Pagamento financiado")]
        Financioamento = 3
    }

    public static class DescricaoEnum
    {
        public static string Descricao(this TipoCompra tp)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])tp
                .GetType().GetField(tp.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
