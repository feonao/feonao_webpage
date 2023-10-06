namespace feonao.Classes
{
    public class Media
    {
        private string playClass = "oi oi-media-play me-2";
        private string pauseClass = "oi oi-media-pause me-2";

        public string Name { get; set; }
        public string Url { get; set; }
        public string? State { get; set; }

        public void SetPause()
        {
            State = pauseClass;
        }

        public void SetPlay()
        {
            State = playClass;
        }

        public void ChangeState()
        {
            if (State == pauseClass)
            {
                State = playClass;
            }
            else if (State == playClass)
            {
                State = pauseClass;
            }
        }

        public String BackgroundColor(bool isCurrent)
        {
            if (isCurrent)
            {
                return "bg-secondary";
            }
            else
            {
                return "bg-white";
            }
        }

        public String BackgroundTextColor(bool isCurrent)
        {
            if (isCurrent)
            {
                return "text-white";
            }
            else
            {
                return "text-dark";
            }
        }
    }
}
