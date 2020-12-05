using MachineLearning.Type;
using System;

namespace MachineLearning.Core
{
    public class Model
    {
        public Layer input;
        public Layer output;

        public virtual void Fit(int epochs, Vector input, Vector target)
        {
            throw new NotImplementedException();
        }
    }
}
