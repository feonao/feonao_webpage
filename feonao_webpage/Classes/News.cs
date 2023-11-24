namespace feonao.Classes
{
    public class News : Media
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public int Order { get; set; }
    }
}
