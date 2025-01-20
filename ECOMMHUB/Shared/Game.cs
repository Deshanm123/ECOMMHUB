﻿namespace ECOMMHUB.Shared
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverImageURL { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
