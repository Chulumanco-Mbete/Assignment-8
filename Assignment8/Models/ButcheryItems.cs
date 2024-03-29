﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class ButcheryItems
    {
        [PrimaryKey, AutoIncrement] public int MeatId { get; set; }
        public string MeatName { get; set; }

        public string MeatImage { get; set; }

        public string MeatDescription { get; set; }

        public double MeatPrice { get; set;}
        
        public int MeatQuantity { get; set; }
    }
}
