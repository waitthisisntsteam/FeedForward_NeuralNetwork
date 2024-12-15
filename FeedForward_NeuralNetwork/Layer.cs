﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedForward_NeuralNetwork
{
    public class Layer
    {
        public Neuron[] Neurons { get; }
        public double[] Outputs { get; }

        public Layer(ActivationFunction activation, int neuronCount, Layer? previousLayer)
        {
            Neurons = new Neuron[neuronCount];
            Outputs = new double[neuronCount];

            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron(activation, previousLayer.Neurons);
                Outputs[i] = Neurons[i].Compute();
            }
        }

        public void Randomize(Random random, double min, double max)
        {
            for (int i = 0; i < Neurons.Length; i++) Neurons[i].Randomize(random, min, max);
        }

        public double[] Compute()
        {
            for (int i = 0; i < Neurons.Length; i++) Outputs[i] = Neurons[i].Compute();

            return Outputs;
        }
    }
}
