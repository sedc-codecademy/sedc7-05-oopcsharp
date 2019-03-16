namespace Demo
{
    public class Song
    {
        public string Title { get; set; }

        public int Length { get; set; }

        public Genre Genre { get; set; }

        public Song(string title, int length, Genre genre)
        {
            this.Title = title;
            this.Length = length;
            this.Genre = genre;
        }

        public string SongInfo()
        {
            return $"Title: {Title}, Length: {Length}s, Genre: {Genre}";
        }
    }
}
