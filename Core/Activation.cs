using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.Core
{
    public abstract class Activation
    {
        public abstract Vector Activate(Vector vector);
        public abstract Vector Deactivate(Vector vector);
    }
}
