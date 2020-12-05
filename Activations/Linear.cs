using System;
using System.Collections.Generic;
using System.Text;
using MachineLearning.Core;
using MachineLearning.Type;

namespace MachineLearning.Activations
{
    public class Linear : Activation
    {
        public override Vector Activate(Vector vector)
        {
            Vector result = new Vector(vector.size);
            for (int i = 0; i < vector.size; i++)
            {
                result[i] = vector[i];
            }
            return result;
        }

        public override Vector Deactivate(Vector vector)
        {
            Vector result = new Vector(vector.size);
            for (int i = 0; i < vector.size; i++)
            {
                result[i] = 1;
            }
            return result;
        }

    }
}
