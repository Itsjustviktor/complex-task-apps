using System;
using System.Collections.Generic;

#nullable disable

namespace Сайт
{
    public partial class Feedback
    {
        public int Idfeedback { get; set; }
        public string Firstname { get; set; }
        public string Problem { get; set; }
        public string Solve { get; set; }
        public string Telnumber { get; set; }
        public bool? End { get; set; }
    }
}
