namespace КП.Model
{
    public class VideoOfDay
    {
        public List<Contents> contents { get; set; }
    }

    public class Contents
    {
        public Video video { get; set; }
    }

    public class Video
    {
        public string title { get; set; }
        public string videoId { get; set ; }        
    }    
}


