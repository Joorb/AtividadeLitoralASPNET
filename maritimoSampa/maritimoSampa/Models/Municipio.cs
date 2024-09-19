namespace maritimoSampa.Models
{
    public class Municipio
    {
        public string nome { get; set; }
        public string regiao { get; set; }
        public double populacao { get; set; }
        public string desc { get; set; }
        public string imgd { get; set; }
        public List<Historia> Historia { get; set; } = new List<Historia>();
        public List<Produto> Produto { get; set; } = new List<Produto>();
    }
}
