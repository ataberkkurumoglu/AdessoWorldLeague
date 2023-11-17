﻿namespace AdessoWorldLeague.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DrawResult? DrawResult { get; set; }
        public int DrawResultId { get; set; }
    }
}
