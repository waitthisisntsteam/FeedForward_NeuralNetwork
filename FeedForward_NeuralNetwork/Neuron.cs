using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedForward_NeuralNetwork
{
    public class Neuron
    {
        double Bias;
        Dendrite[] Dendrites;

        public double Output { get; set; }
        public double Input { get; private set; }
        public ActivationFunction Activation { get; set; }

        public Neuron(ActivationFunction activation, Neuron[] previousNeurons)
        {
            Activation = activation;

            Dendrites = new Dendrite[previousNeurons.Length];
            for (int i = 0; i < Dendrites.Length; i++) Dendrites[i] = new Dendrite(this, previousNeurons[i], 0);
        }

        public void Randomize(Random random, double min, double max)
        {
            for (int i = 0; i < Dendrites.Length; i++) Dendrites[i].Weight = random.Next((int)min, (int)max);
        }

        public double Compute()
        {
            return 0; // outputs of the dendrites and the bias, then putting the input through the activation function
        }
    }
}
