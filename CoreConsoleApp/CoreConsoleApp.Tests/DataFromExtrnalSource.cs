using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace CoreConsoleApp.Tests
{
    class DataFromExtrnalSource
    {
        public static IEnumerable<object[]> GetData()
        {
            List<object[]> testData = new List<object[]>();
            //"C:\PersonalFolder\StudyThings\CoreConsoleApp\CoreConsoleApp\Test.csv"
            string[] csvAllLines =  File.ReadAllLines(@"\Test.csv");

            foreach(string csvRow in csvAllLines)
            {
                //object[] testData = new object[];
                Console.WriteLine(csvRow);
                IEnumerable<int> rowAsArray = csvRow.Split(",").Select(int.Parse);
                object[] testCase = rowAsArray.Cast<object>().ToArray();

                testData.Add(testCase);
            }

            return testData;

        }
    }
}
