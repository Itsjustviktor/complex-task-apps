using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Delivery
    {
        public int Iddelivery { get; set; }
        public string Addressdelivery { get; set; }
        public TimeSpan? Dateofbegin { get; set; }
        public TimeSpan? Dateofend { get; set; }
        public double? Cost { get; set; }
        public string Typedelivery { get; set; }
        public int? Idorder { get; set; }
        public string Tracknum { get; set; }
    }
}
