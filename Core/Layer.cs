using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MachineLearning.Core
{
    public abstract class Layer
    {
        public Layer next;
        public Layer prev;

        public float rate;
        
        public abstract void Forward();
        public abstract void Backward();
        
    }
}
