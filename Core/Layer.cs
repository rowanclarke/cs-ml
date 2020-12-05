using System;

namespace MachineLearning.Core
{
    public class Layer
    {
        public Layer next;
        public Layer prev;

        public double rate;

        public virtual void Forward()
        {
            throw new NotImplementedException();
        }

        public virtual void Backward()
        {
            throw new NotImplementedException();
        }

        public virtual Feed ToFeed()
        {
            throw new NotImplementedException();
        }
    }
}
