using MachineLearning.Type;
using System;
using MachineLearning.Layers;

namespace MachineLearning.Core
{
    public class Model
    {
        public Input input;
        public Output output;

        public virtual void Fit(Vector input, Vector target)
        {
            throw new NotImplementedException();
        }
    }
}
