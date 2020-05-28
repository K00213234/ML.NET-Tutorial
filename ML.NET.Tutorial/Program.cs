namespace ML.NET.Tutorial
{
	using ML_NET_TutorialML.Model;
	using System;
	using static System.Environment;
	/// <summary>
	/// ML.NET Tutorial Program
	/// https://dotnet.microsoft.com/learn/ml-dotnet/get-started-tutorial/intro
	/// </summary>
	class Program
	{
		const string exit = "exit";
		static Boolean contineProgramLoop = true;
		static void Main()
		{
			do
			{
				PrintInstructions();
				String userinput = Console.ReadLine();
				switch (userinput.ToLower())
				{
					case exit: ExitProgram(); break;
					default: TestInput(userinput); break;
				}
			}
			while (contineProgramLoop);
		}
		private static void ExitProgram()
		{
			contineProgramLoop = false;
			Console.WriteLine($"Exiting Program.");
		}
		private static void PrintInstructions()
		{
			Console.WriteLine($"Type '{exit}' to exit the program");
			Console.WriteLine($"Enter a comment for the ML.NET Program to test for 'Toxic' content");
		}
		private static void TestInput(String userInput)
		{
			ModelInput input = new ModelInput
			{
				SentimentText = userInput,
			};
			ModelOutput result = ConsumeModel.Predict(input);
			Console.WriteLine($"Text: {input.SentimentText}{NewLine}Is Toxic: {result.Prediction}");
		}
	}
}