using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectCreator.EffectControls {
    interface IEffectUserControl {
        IEffect GetEffect();
        event EventHandler EffectModified;
        void RevertChanges();
        void ApplyChanges();
    }
}
