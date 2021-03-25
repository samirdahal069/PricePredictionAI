using PricePredictionAIML.Model;
using System;

namespace PricePredictionAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Add input data
            var input = new ModelInput();
            input.Trip_distance = 2;
            input.Passenger_count = 1;
            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine(result.Score);

        }
    }
}
