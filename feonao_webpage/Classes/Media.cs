namespace feonao.Classes
{
    public class Media
    {
        private string playClass = "oi oi-media-play me-2";
        private string pauseClass = "oi oi-media-pause me-2";
        private string? _state;


        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public void SetPause()
        {
            _state = pauseClass;
        }

        public void SetPlay()
        {
            _state = playClass;
        }

        public void ChangeState()
        {
            if (_state == pauseClass)
            {
                _state = playClass;
            }
            else if (_state == playClass)
            {
                _state = pauseClass;
            }
        }

        public string BackgroundColor(bool isCurrent)
        {
            if (isCurrent)
            {
                return "bg-secondary";
            }
            else
            {
                return "bg-dark";
            }
        }

        public string BackgroundTextColor(bool isCurrent)
        {
            if (isCurrent)
            {
                return "text-dark";
            }
            else
            {
                return "text-light";
            }
        }

        public string? GetState()
        {
            return _state;
        }
    }
}
