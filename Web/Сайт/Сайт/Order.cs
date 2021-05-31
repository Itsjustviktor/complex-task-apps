using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Order
    {
        public int Idorder { get; set; }
        public string Status { get; set; }
        public double? Priceoreder { get; set; }
        public string Paymentmethod { get; set; }
        public string Takemethod { get; set; }
        public int? Idbuyer { get; set; }
        public string Tracknum { get; set; }
        public string Adress { get; set; }
        public DateTime? Date { get; set; }
    }
}
