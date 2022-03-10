using System;
using System.Collections.Generic;

namespace avansTeam.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PerformanceId { get; set; }
        public int HallId { get; set; }

        public Movie Movie { get; set; }
        public Performance Performance { get; set; }
        public Hall Hall { get; set; }

    }
}
