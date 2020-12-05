using MachineLearning.Core;
using MachineLearning.Type;
using System;

namespace MachineLearning.Activations
{
    public class Sigmoid : Activation
    {
        public override Vector Activate(Vector vector)
        {
            Vector result = new Vector(vector.size);
            for (int i = 0; i < vector.size; i++)
            {
                result[i] = 1 / (1 + Math.Exp(-vector[i]));
            }
            return result;
        }

        public override Vector Deactivate(Vector vector)
        {
            Vector result = Activate(vector);
            return result * (1 - result);
        }
    }
}
