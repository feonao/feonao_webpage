namespace feonao.Classes
{
    public class Video : Media
    {
        public Video(string name, string url)
        {
            Name = name;
            Url = url;
            SetPlay();
        }
    }
}
