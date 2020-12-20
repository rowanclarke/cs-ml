using MachineLearning.Core;
using MachineLearning.Type;

namespace MachineLearning.Activations
{
    public class ReLU : Activation
    {
        public override Vector Activate(Vector vector)
        {
            Vector result = new Vector(vector.size);
            for (int i = 0; i < vector.size; i++)
            {
                result[i] = vector[i] > 0 ? vector[i] : 0;
            }
            return result;
        }

        public override Vector Deactivate(Vector vector)
        {
            Vector result = new Vector(vector.size);
            for (int i = 0; i < vector.size; i++)
            {
                result[i] = vector[i] > 0 ? 1 : 0;
            }
            return result;
        }
    }
}
