namespace feonao.Classes
{
    public class Sound : Media
    {
        public string Artwork { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }

        public Sound(string name, string url)
        {
            Name = name;
            Url = url;
            Artwork = "";
            SetPlay();
        }
    }
}
