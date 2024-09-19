namespace maritimoSampa.Models
{
    public class Historia
    {
        public string resumoHistorico { get; set; }
        public string imgh { get; set; }
        public List<Produto> Produto { get; set; } = new List<Produto>();
    }
}
