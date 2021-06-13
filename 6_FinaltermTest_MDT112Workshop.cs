using System;

namespace _6_FinaltermTest_MDT112Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int InputNumberFile = int.Parse(Console.ReadLine());
                int NumberFileAddress = int.Parse(Console.ReadLine());
                int OutputNumberFile = ((NumberFileAddress - 1) / NumberFileAddress) + 1;
                string[,] nameArray = new string[InputNumberFile, OutputNumberFile];

                for (int i = 0; i < OutputNumberFile; i++)
                {
                    for (int j = 0; j < OutputNumberFile; j++)
                    {
                        int peopleIndex = (i * OutputNumberFile) + j;
                        if (peopleIndex < InputNumberFile)
                        { nameArray[j, i] = Console.ReadLine(); }
                        else
                        { nameArray[j, i] = "double [,]"; }
                    }
                }

                static string NumberProcessing(int InputNumberFile, int NumberFileAddress, int OutputNumberFile, string nameArray)
                {
                    if (NumberFileAddress < InputNumberFile.oddNumber(0) && OutputNumberFile < nameArray.evenNumber(1))
                    {
                        return nameArray[oddNumber, evenNumber];
                    }
                    return nameArray;
                }

                static double[,] ReadNumberDataFromFile(string NumberDataFilePath)
                {
                    string[] lines = System.IO.File.ReadAllLines(NumberDataFilePath);
                    int oddNumber = lines.Length;
                    int evenNumber = lines[0].Split(',').Length;
                    double[,] NumberDataArray = new double[oddNumber, evenNumber];

                    for (int i = 0; i < oddNumber; i++)
                    {
                        string[] items = lines[i].Split(',');
                        for (int j = 0; j < evenNumber; j++)
                        {
                            NumberDataArray[i, j] = double.Parse(items[j]);
                        }
                    }
                    return NumberDataArray;
                    
                    static void WriteNumberDataToFile(string NumberDataFilePath, double[,] NumberDataArray)
                    {
                        string NumberDataString = "";
                        for (int i = 0; i < NumberDataArray.GetLength(0); i++)
                        {
                            for (int j = 0; j < NumberDataArray.GetLength(1) - 1; j++)
                            {
                                NumberDataString += NumberDataArray[i, j] + ", ";
                            }
                            NumberDataString += NumberDataArray[i, NumberDataArray.GetLength(1) - 1];
                            NumberDataString += "\n";
                        }
                        System.IO.File.WriteAllText(NumberDataFilePath, NumberDataString);
                    }

                    int NumberDataString = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                    Console.WriteLine("[0] Show all recent files");
                    Console.WriteLine("[1] Open new file");
                    Console.WriteLine("[2] Open recent file");
                    Console.WriteLine("[3] Exit");
                    Console.ReadLine();

                }
            }
        }
    }
}
