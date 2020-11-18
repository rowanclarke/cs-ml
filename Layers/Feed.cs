using System;
using System.Collections.Generic;
using System.Text;
using MachineLearning.Core;

namespace MachineLearning.Layers
{
    public class Feed : Layer
    {
        public new Feed prev;

        public Activation activation;
        public int size;
        public Vector[] weights;
        public Vector[] buffer;
        public Vector neurons;
        public Vector target;
        public Vector sum;

        public Feed(int size, Activation activation, Feed prev)
        {
            this.size = size;
            this.activation = activation;
            this.prev = prev;
            prev.next = this;
            weights = new Vector[prev.size];
            buffer = new Vector[prev.size];
            neurons = new Vector(size);
            sum = new Vector(size);
        }

        public override void Forward()
        {
            for (int i = 0; i < size; i++)
            {
                sum += prev.weights[i] * prev.neurons;
            }
            neurons = activation.Activate(sum);
        }

        public override void Backward()
        {
            for (int j = 0; j < prev.size; j++)
            {
                buffer[j] = rate * 2 * ((neurons - target) * activation.Deactivate(sum));
                prev.target[j] = 0;
                for (int i = 0; i < size; i++)
                {
                    prev.target[j] -= buffer[j][i] * weights[j][i];
                    weights[j][i] -= buffer[j][i] * prev.neurons[j];
                }
                prev.target[j] += prev.neurons[j];
            }
        }
    }
}
