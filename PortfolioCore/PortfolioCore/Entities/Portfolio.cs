namespace PortfolioCore.Entities
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string PortfolioTitle { get; set; }
        public string PortfolioDescription { get; set; }
        public string PortfolioImageURL { get; set; }
        public string URL { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
