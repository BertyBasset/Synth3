using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Controls {
    internal interface iControl {
        public double Value { get; set; }
        public event EventHandler<double>? ValueChanged;

    }
}
