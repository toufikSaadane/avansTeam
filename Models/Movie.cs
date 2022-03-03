using System;
using System.Collections.Generic;

namespace avansTeam.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimalAge { get; set; }
        public int Duration { get; set; }
        public string Image { get; set; }

        public ICollection<Performance> Performances { get; set; } = new List<Performance>();
    }
}
