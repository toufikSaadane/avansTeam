using System;
using System.Collections.Generic;

namespace avansTeam.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }

        public ICollection<Performance> Perfomances { get; set; } = new List<Performance>();

    }
}
