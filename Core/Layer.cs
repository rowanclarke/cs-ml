using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MachineLearning.Core
{
    public class Layer
    {
        public delegate void Activation();
        private int[] shape;
        private Activation activation;
        public Layer(int[] shape, Activation activation)
        {
            this.shape = shape;
            this.activation = activation;
        }

    }
}
