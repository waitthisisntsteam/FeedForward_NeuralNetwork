using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedForward_NeuralNetwork
{
    public class Dendrite
    {
        //Gradient Descent:
        public double WeightUpdate { get; set; }
        public double PreviousWeightUpdate { get; set; }


        //Base Network:
        public Neuron Next { get; set; }
        public Neuron Previous { get; set; }
        public double Weight { get; set; }

        public Dendrite(Neuron next, Neuron previous, double weight) => (Next, Previous, Weight) = (next, previous, weight);

        public double Compute() => Previous.Output * Weight;


        //Gradient Descent:
        public void ApplyUpdates(double momentum)
        {
            WeightUpdate += PreviousWeightUpdate * momentum;
            Weight += WeightUpdate;
            PreviousWeightUpdate = WeightUpdate;
            WeightUpdate = 0;
        }
    }
}
