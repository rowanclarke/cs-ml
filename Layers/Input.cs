using MachineLearning.Core;
using MachineLearning.Type;
using System;

namespace MachineLearning.Layers
{
    public class Input : Layer
    {
        public Input(int size)
        {
            this.size = size;
            target = new Vector(size); // 
            values = new Vector(size);
        }

        public override void Run()
        {
            next.Run();
        }
    }
}
