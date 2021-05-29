using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Transaction
    {
        public int? Idorder { get; set; }
        public TimeSpan? Transactiontime { get; set; }
        public int Idtransaction { get; set; }
        public string Receipt { get; set; }
    }
}
