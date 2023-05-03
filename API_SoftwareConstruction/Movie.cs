namespace JURNAL_KPL_MOD9_1302213015
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; } = new List<string>();
        public string description { get; set; }

        public Movie(string Title, string Director, List<string> Stars, string description) 
        {
            this.Title = Title;
            this.Director = Director;   
            this.Stars = Stars;
            this.description = description;
        }

    }
}
