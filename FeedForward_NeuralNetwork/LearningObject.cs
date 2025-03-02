using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedForward_NeuralNetwork
{
    public class LearningObject <T>
    {
        public double Fitness;
        public T Player; //player that has an action function that takes in: double[], and makes a decision from the network's output
        public NeuralNetwork Network;

        public LearningObject(double fitness, T player, NeuralNetwork neuralNetwork)
        {
            Fitness = fitness;
            Player = player;
            Network = neuralNetwork;
        }
    }
}
