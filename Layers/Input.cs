using MachineLearning.Core;
using MachineLearning.Type;
using System;

namespace MachineLearning.Layers
{
    public class Input : Layer
    {
        public int size;
        public Vector neurons;
        public Input(int size)
        {
            this.size = size;
            neurons = new Vector(size);
        }

        public override void Forward()
        {
            throw new NotImplementedException();
        }
        public override void Backward()
        {
            throw new NotImplementedException();
        }
    }
}
