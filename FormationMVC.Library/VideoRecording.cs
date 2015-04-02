using System;
using System.Collections.Generic;



namespace FormationMVC.Library
{
    public class VideoRecording : IProduct
    {
        public int Id { get; set; }
        public string Director { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ImageName { get; set; }
        public int YearReleased { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public string Rating { get; set; }
        public int Duration { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}