using System;
using System.Collections;
using System.Collections.Generic;

namespace MachineLearning.Core
{
    public class Model
    {
        private List<Layer> layers = new List<Layer>();

        public Model(List<Layer> layers)
        {
            this.layers = layers;
        }

        public Model() { }

        public void Add(Layer layer)
        {
            layers.Add(layer);
        }
    }
}
