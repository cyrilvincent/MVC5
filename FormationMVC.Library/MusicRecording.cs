using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormationMVC.Library
{
    public class MusicRecording : IProduct
    {
        public int Id { get; set; }
        public string ArtistName {get; set;}
        public string Title {get; set;}
        public string Category {get; set;}
        public string ImageName {get; set;}
        public int NumberOfTracks {get; set;}
        public double Price {get; set;}
        public int StockCount {get; set;}

        public override string ToString()
        {
            return ArtistName + " " + Title;
        }
    }
}