using System.Collections.Generic;

namespace ShareYourPlaylist.Models
{
    public class HomeViewModel
    {
        public string Title { get; set; } = "Welcome VibeSync!";
        public string WelcomeMessage { get; set; } = "Welcome to VibeSync!";
        public string Description { get; set; } = "Discover and share playlists with your friends!";
        public string ImageUrl { get; set; } = "/images/welcome-image.jpg"; // Path to a static welcome image

    }
}
