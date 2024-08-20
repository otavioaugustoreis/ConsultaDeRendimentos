namespace AplicacaoDeInvestimentos.Entity
{
    public class InvestimentoEntity
    {
        public decimal Valor { get; set; }
        public string? TipoInvestimento { get; set; }

        public InvestimentoEntity(decimal valor, string tipoInvestimento)
        {
            Valor = valor;
            TipoInvestimento = tipoInvestimento;
        }

        public InvestimentoEntity()
        {
        }
    }
}
