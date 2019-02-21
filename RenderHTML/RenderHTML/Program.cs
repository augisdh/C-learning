using System;

namespace RenderHTML
{
    class Program
    {
        public static void Main()
        {
            string inputValue = "The quick brown fox jumps over the lazy dog. Something sweet! Task is done +- bye bye and good night!";
            int[][] inputArr = new int[][]
            {
            new int[2] { 4, 15 },
            new int[2] { 35, 8 },
            new int[2] { 45, 15},
            new int[2] { 75, 2},
            new int[2] { 90, 10}
            };

            Console.WriteLine(OutputHtml(inputValue, inputArr));
        }

        static public string OutputHtml(string text, int[][] arr)
        {
            var html = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    html = text.Substring(0, arr[i][0]) + "<br>" + text.Substring(arr[i][0], arr[i][1]) + "</br>";
                }
                else if (i == arr.Length - 1)
                {
                    html += text.Substring(arr[i - 1][0] + arr[i - 1][1], arr[i][0] - (arr[i - 1][0] + arr[i - 1][1])) + "<br>" + text.Substring(arr[i][0], arr[i][1]) + "</br>" + text.Substring(arr[i][0] + arr[i][1]);
                }
                else
                {
                    html += text.Substring(arr[i - 1][0] + arr[i - 1][1], arr[i][0] - (arr[i - 1][0] + arr[i - 1][1])) + "<br>" + text.Substring(arr[i][0], arr[i][1]) + "</br>";
                }
            }

            return html;
        }
    }
}
