using Synth.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth.Modules.Effects {
    public interface iEffect : iModule {
        public iModule Source { get; set; }
    }
}
