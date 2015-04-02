using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FormationMVC.Library
{
    public class MusicCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}