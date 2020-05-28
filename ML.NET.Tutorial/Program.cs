namespace ML.NET.Tutorial
{
	using ML_NET_TutorialML.Model;
	using System;
	/// <summary>
	/// ML.NET Tutorial Program
	/// https://dotnet.microsoft.com/learn/ml-dotnet/get-started-tutorial/intro
	/// </summary>
	class Program
	{
		static void Main()
		{
			ModelInput input = new ModelInput
			{
				SentimentText = "That is rude."
			};
			ModelOutput result = ConsumeModel.Predict(input);
			Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
		}
	}
}