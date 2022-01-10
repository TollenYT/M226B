using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class DisplayEventArgsImpl : IDisplayEventArgs
    {
        public string DisplayText { get; set; }

        public DisplayEventArgsImpl(string displayText)
        {
            DisplayText = displayText;
        }
    }
}
