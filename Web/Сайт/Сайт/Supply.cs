using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Supply
    {
        public int Idsupply { get; set; }
        public int? Idgood { get; set; }
        public string Provider { get; set; }
        public double? Pricesupply { get; set; }
        public double? Priceposition { get; set; }
        public int? Quantitydeliveredgoods { get; set; }
    }
}
