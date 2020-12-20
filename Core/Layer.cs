using System;

using MachineLearning.Type;

namespace MachineLearning.Core
{
    public class Layer
    {
        public Layer next;
        public Layer prev;

        public int size;
        public Vector values;
        public Vector target;

        public double rate;

        public virtual void Forward()
        {
            throw new NotImplementedException();
        }

        public virtual void Backward()
        {
            throw new NotImplementedException();
        }

        public virtual void Run()
        {
            Forward();
            next.Run();
            Backward();
        }

    }
}
