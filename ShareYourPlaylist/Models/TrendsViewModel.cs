namespace ShareYourPlaylist.Models
{
    public class TrendsViewModel
    {
        public List<(string Name, int FollowersCount)> PlaylistFollowersData { get; set; } = new List<(string Name, int FollowersCount)>();
    }
}
