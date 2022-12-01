using System;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = {
                @"Dude, this is not acceptable, If you donot upload that carl picture back I will see your end.",
                @"This is great Thanks for putting this for my consumption.",
                @"This is NOT great pl remove it.",
                @"This is BS."
            };

            Console.WriteLine("Using model to make single prediction -- Comparing actual Sentiment with predicted Sentiment from sample data...\n\n");

            foreach (string text in texts)
            {
                // Create single instance of sample data from first line of dataset for model input
                SampleClassification.ModelInput sampleData = new SampleClassification.ModelInput();
                sampleData.SentimentText = text;

                // Make a single prediction on the sample data and print results
                var predictionResult = SampleClassification.Predict(sampleData);

                Console.Write($"Sentiment: {predictionResult.Sentiment}::SentimentText: {text}");
                Console.WriteLine($"\n\nPredicted Sentiment: {predictionResult.PredictedLabel}\n\n");
            }

            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();

        }
    }
}