using System;
using MachineLearning.Type;

namespace MachineLearning.Core
{
    public class Activation
    {
        public virtual Vector Activate(Vector vector)
        {
            throw new NotImplementedException();
        }
        public virtual Vector Deactivate(Vector vector)
        {
            throw new NotImplementedException();
        }
    }
}
