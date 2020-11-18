using System;
using System.Collections.Generic;
using System.Text;
using MachineLearning.Core;

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
