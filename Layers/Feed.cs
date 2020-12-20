using MachineLearning.Type;
using MachineLearning.Core;


namespace MachineLearning.Layers
{
    public class Feed : Layer
    {

        public Activation activation;

        public Vector[] weights;
        public Vector[] buffer;
        public Vector bias;
        public Vector sum;

        public Feed(int size, Activation activation, Layer prev)
        {
            this.size = size;
            this.activation = activation;
            this.prev = prev;
            prev.next = this;
            weights = new Vector[prev.size];
            buffer = new Vector[prev.size];
            for (int i = 0; i < prev.size; i++)
            {
                weights[i] = new Vector(size);
                buffer[i] = new Vector(size);
            }
            values = new Vector(size);
            target = new Vector(size);
            bias = new Vector(size);
            sum = new Vector(size);
        }

        public override void Forward()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < prev.size; j++)
                {
                    sum[i] += bias[i] + weights[j][i] * prev.values[i];
                }
            }
            values = activation.Activate(sum);
        }

        public override void Backward()
        {
            for (int j = 0; j < prev.size; j++)
            {
                buffer[j] = rate * 2 * ((values - target) * activation.Deactivate(sum));
                prev.target[j] = 0;
                for (int i = 0; i < size; i++)
                {
                    prev.target[j] -= buffer[j][i] * weights[j][i];
                    weights[j][i] -= buffer[j][i] * prev.values[j];
                }
                prev.target[j] += prev.values[j];
            }
        }
    }
}
