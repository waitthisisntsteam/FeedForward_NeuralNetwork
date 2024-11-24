using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedForward_NeuralNetwork
{
    public class NeuralNetwork
    {
        Layer[] Layers;
        ErrorFunction Error;

        public NeuralNetwork(ActivationFunction activation, ErrorFunction error)
        {
        }

        public void Randomize(Random random, double min, double max)
        {
        }
    }
}
