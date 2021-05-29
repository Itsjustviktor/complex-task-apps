using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Orderedgood
    {
        public int Idorderedgoods { get; set; }
        public int? Idgood { get; set; }
        public int? Quantityorderedgoods { get; set; }
        public double? Price { get; set; }
        public int? Idorder { get; set; }
    }
}
