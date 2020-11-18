using System;
using System.Collections;
using System.Collections.Generic;

namespace MachineLearning.Core
{
    public abstract class Model
    {
        public Layer input;
        public Layer output;

        public abstract void Fit(int epochs, Vector input, Vector target);

    }
}
