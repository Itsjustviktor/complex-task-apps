using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Good
    {
        public int Idgood { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Dimension { get; set; }
        public string Provider { get; set; }
        public double? Weight { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public int? Guarantee { get; set; }
        public int? Quantity { get; set; }
        public bool? Availability { get; set; }
        public string Firm { get; set; }
        public string Subfirm { get; set; }
        public string Picture { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
    }
}
