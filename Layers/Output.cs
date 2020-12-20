using System;
using System.Collections.Generic;
using System.Text;

using MachineLearning.Core;

namespace MachineLearning.Layers
{
    public class Output : Layer
    {
        public Output(Layer output)
        {
            prev = output;
            output.next = this;
        }

        public override void Run()
        {
            prev.target = values;
        }
    }
}
