namespace API_Rest_DDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
    }
}
